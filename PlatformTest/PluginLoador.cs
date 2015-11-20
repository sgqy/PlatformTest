using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

////////////////////
// 如何调用? (伪代码)
////////////////////
// var Plugins = LoadPlugins<IPlugin>("plugins").ToDictionary(k => k.Name, v => v);
// // 你需要自己在 IPlugin 里定义 Name 成员. 它当然也可以起别的名字
// var dll = Plugins["Plugin Name"];
// dll.DoSomething();
////////////////////

namespace sgqy
{
    public class PluginLoador
    {
        public IEnumerable<IPlugin> LoadPlugins<IPlugin>(string path, string searchPattern = "*.dll")
        {
            if (!Directory.Exists(path)) return new IPlugin[] { };

            // 得到 dll 文件列表
            return Directory.GetFiles(path, searchPattern)
                // 获取 dll 文件的内部名称
                .Select(x => Assembly.Load(AssemblyName.GetAssemblyName(x)))
                // 过滤加载失败的项
                .Where(x => x != null)
                // 使用 SelectMany 拆包, 去掉所有接口库和抽象库
                .SelectMany(x => x.GetTypes().Where(y => !y.IsInterface && !y.IsAbstract))
                // 过滤所有不含名称的 Assembly
                .Where(x => x.GetInterface(typeof(IPlugin).FullName) != null)
                // 所有重复的 dll 只选一个
                .Distinct()
                // 加载(实例化)这些 dll
                .Select(x => (IPlugin)Activator.CreateInstance(x))
                ;
        }
    }
}