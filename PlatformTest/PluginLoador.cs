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

            // 得到库文件列表
            return Directory.GetFiles(path, searchPattern)
                // 获取库文件的内部名称并加载
                .Select(x => Assembly.Load(AssemblyName.GetAssemblyName(x)))
                // 过滤加载失败的库
                .Where(x => x != null)
                // 拆出所有类，并过滤接口类和抽象类
                .SelectMany(x => x.GetTypes().Where(y => !y.IsInterface && !y.IsAbstract))
                // 过滤所有不含 IPlugin 接口的类
                .Where(x => x.GetInterface(typeof(IPlugin).FullName) != null)
                // 所有重复的类里只选一个
                .Distinct()
                // 加载(实例化)这些类
                .Select(x => (IPlugin)Activator.CreateInstance(x))
                ;
        }
    }
}