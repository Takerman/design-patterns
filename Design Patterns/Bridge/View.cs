namespace Takerman.DesignPatterns.BridgePattern
{
    public abstract class View
    {
        private readonly IResource resource;

        public View(IResource resource)
        {
            this.resource = resource;
        }

        public abstract string Show();
    }
}
