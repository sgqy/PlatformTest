using IData;
using System.Linq;
using YamlDotNet.Serialization;

namespace Plugin
{
    public class Sherlock : IData.IData
    {
        public string Name
        {
            get { return "Sherlock"; }
        }

        public string transmiss(Data[] d)
        {
            var tw = new System.IO.StringWriter();

            var ser = new Serializer();
            ser.Serialize(tw, d.Select(x => new { x.id, x.src, x.dst }));

            return tw.ToString();
        }
    }
}