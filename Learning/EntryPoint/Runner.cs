using WriterLibrary;
namespace EntryPoint
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            Writer writer = new Writer();
            string outMessage = "HelloWorld";
            writer.ShowMessage(outMessage);
        }
    }
}
