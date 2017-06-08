using System;

public abstract class Singleton<T>
{
    protected static readonly T mInstance = Activator.CreateInstance<T>();
    public static T Instance { get { return mInstance; } }

    protected Singleton() { }
}