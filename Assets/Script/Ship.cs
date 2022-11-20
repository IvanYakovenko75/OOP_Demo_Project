using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ship : MonoBehaviour, IControlable //abstraction
{

    public virtual void Fly()
    {
        Debug.Log("Ship is Fly");
    }

    public virtual void Shot()
    {
        Debug.Log("Ship is Shot");
    }
}
