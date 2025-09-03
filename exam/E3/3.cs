public class ResourceManager: IDisposable
{
    public bool IsDisposed { get; set; }
    public ResourceManager()
    {
        IsDisposed = false;
    }
    public void Dispose()
    {
        
        
        IsDisposed=true;
        GC.SuppressFinalize(this);
    }

}
