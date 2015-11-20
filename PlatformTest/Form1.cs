using IData;
using sgqy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlatformTest
{
    public partial class FormMain : Form
    {
        private List<IData.Data> moredata = new List<Data>();

        private Dictionary<string, IData.IData> plugins = new PluginLoador().LoadPlugins<IData.IData>("plugins")
                        .ToDictionary(k => k.Name, v => v);

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                textResult.Clear();
                var dll = plugins[textPlugin.Text];
                var d = new Data();
                d.id = (int)numDataID.Value;
                d.src = textSrc.Text;
                d.dst = textDst.Text;
                moredata.Add(d);
                textResult.AppendText(dll.transmiss(moredata.ToArray()) + "\r\n");
            }
            catch (Exception ec) // 插件选取失败, 此时可以使用 fall-back 方法
            {
                textResult.AppendText(ec.ToString() + "\r\n");
            }
        }
    }
}