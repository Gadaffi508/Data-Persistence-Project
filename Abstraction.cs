using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Abstraction : MonoBehaviour
{
    protected virtual void Init()
    {
        
    }
}
public class EnemySkeleton : Abstraction
{
    protected override void Init()
    {
        base.Init();
    }
}
