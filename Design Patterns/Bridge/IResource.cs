namespace Takerman.DesignPatterns.BridgePattern
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string Image();
        string Url();
    }
}