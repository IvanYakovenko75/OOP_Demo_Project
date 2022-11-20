using UnityEngine;

public class Cruiser : Ship, IControlable //Inheritance
{
    public void GiperJump()
    { 
    if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("Cruiser is GiperJump");
        }
    }

    override public void Shot() //polymorphism
    {
        Debug.Log("Cruiser is Laser Shot");
    }

    public void Update()
    {
        GiperJump();
    }

}
