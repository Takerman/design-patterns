using System;

namespace Takerman.DesignPatterns.BridgePattern
{
    public class ArtistResource : IResource
    {
        private Artist artist;

        public ArtistResource(Artist artist)
        {
            this.artist = artist;
        }

        public string Image()
        {
            return this.artist.Image();
        }

        public string Snippet()
        {
            return this.artist.Bio();
        }

        public string Title()
        {
            return this.artist.Title();
        }

        public string Url()
        {
            return this.artist.Url();
        }
    }
}
