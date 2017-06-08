using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : Singleton<SingletonTest>
{
    public string items="Singleton Test";
    void Start()
    {

    }

    void Update()
    {

    }
}
