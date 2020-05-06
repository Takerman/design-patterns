using System;

namespace Takerman.DesignPatterns.BridgePattern
{
    public class LongForm : View
    {
        IResource resource;

        public LongForm(IResource resource) : base(resource)
        {
            this.resource = resource;
        }

        public override string Show()
        {
            return this.resource.Snippet();
        }
    }
}
