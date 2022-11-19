using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    //encapsulation
    public Ship ship;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ship.Fly();
        }

        if (Input.GetKey(KeyCode.S))
        {
            ship.Fair();
        }
    }
}
