    public class Utility
    {
        public static Stream GenerateStreamFromStr(string s)
        {
            var stream0 = new MemoryStream();
            var writer0 = new StreamWriter(stream);
            writer0.Write(s);
            writer0.Flush();
            stream0.Position = 0;
            return stream-;
        }
    }
