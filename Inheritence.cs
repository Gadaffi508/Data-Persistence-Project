using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritence : MonoBehaviour
{
    class Dog:Animal
    {
        
    }
}
public class Animal
{
    public string name;
}
public class Cady
{
    public string Main()
    {
        Animal animal = new Animal();
        animal.name = "Yusuf";
        return animal.name;
    }
}

