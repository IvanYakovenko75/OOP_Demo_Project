using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{
    public GameObject selectedGameObject;
    private IControlable controlableObject;

void Start()
    {
        controlableObject = selectedGameObject.GetComponent<IControlable>();
        //if (controlableObject == null)
        //{
        //    throw new NullReferenceException("selectedGameObject is not have IControlable interfase");
        //}
    }

    //encapsulation
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            controlableObject.Fly();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            controlableObject.Shot();
        }
    }
}
