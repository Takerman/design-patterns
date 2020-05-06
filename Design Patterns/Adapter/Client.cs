namespace Takerman.DesignPatterns.AdapterPattern
{
    public class Client
    {
        public Adapter adapter;

        public Client(Adapter adapter)
        {
            this.adapter = adapter;
        }
    }
}
