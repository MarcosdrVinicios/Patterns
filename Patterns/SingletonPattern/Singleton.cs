namespace Patterns.SingletonPattern;

public sealed class Singleton
{
    private Singleton() { }

    private static Singleton instance;
    
    private static readonly object lockObject = new();
    
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
        }

        return instance;
    }
}