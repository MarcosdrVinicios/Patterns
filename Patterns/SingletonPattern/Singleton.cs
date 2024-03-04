namespace Patterns.SingletonPattern;

public sealed class Singleton
{
    private Singleton() { }

    private static Singleton instant;
    
    private static readonly object lockObject = new();
    
    public static Singleton GetInstance()
    {
        if (instant == null)
        {
            lock (lockObject)
            {
                if (instant == null)
                {
                    instant = new Singleton();
                }
            }
        }

        return instant;
    }
}