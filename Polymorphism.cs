using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polymorphism : MonoBehaviour
{
    [SerializeReference]
    public Vegetable vegetable = new tomato();
}
public class Food
{

}
[Serializable]
public class Vegetable : Food
{ 

}
public class tomato : Vegetable
{ 

}

