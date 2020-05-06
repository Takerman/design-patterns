using System;

namespace Takerman.DesignPatterns.BridgePattern
{
    public class Artist
    {
        public string Bio()
        {
            return string.Empty;
        }

        internal string Url()
        {
            throw new NotImplementedException();
        }

        internal string Title()
        {
            throw new NotImplementedException();
        }

        internal string Image()
        {
            throw new NotImplementedException();
        }
    }
}