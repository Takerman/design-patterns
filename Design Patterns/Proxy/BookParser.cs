namespace Takerman.DesignPatterns.Proxy
{
    public class BookParser : IBookParser
    {
        public BookParser(string book)
        {
            // expensive operations
        }

        public int GetNumPages()
        {
            return 0; // returns the nnumber of the pages of the book
        }
    }
}
