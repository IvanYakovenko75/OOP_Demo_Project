using UnityEngine;

public class Cruiser : Ship, IControlable //Inheritance
{
    [SerializeField] private StatusController statusController;

    public void SetGiperJump()
    { 
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
        if (Input.GetKeyDown(KeyCode.G))
        {
            SetGiperJump();
            statusController.SetGiperJump();
        }
    }

}
