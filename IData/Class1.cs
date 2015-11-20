namespace IData
{
    public class Data
    {
        public int id;
        public string src;
        public string dst;
    }

    public interface IData
    {
        string Name { get; }

        string transmiss(Data[] d);
    }
}