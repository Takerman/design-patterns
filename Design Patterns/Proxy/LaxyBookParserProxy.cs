namespace Takerman.DesignPatterns.Proxy
{
    public class LaxyBookParserProxy : IBookParser
    {
        private string book;

        private BookParser parser;

        public LaxyBookParserProxy(string book)
        {
            this.book = book;
        }

        public int GetNumPages()
        {
            if (this.parser == null)
            {
                this.parser = new BookParser(this.book);
            }

            return parser.GetNumPages();
        }
    }
}
