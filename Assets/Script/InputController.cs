using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputController : MonoBehaviour
{
    public GameObject selectedGameObject;
    private IControlable controlableObject;
    [SerializeField] private StatusController statusController;

    void Start()
    {
        controlableObject = selectedGameObject.GetComponent<IControlable>();
    }

    //encapsulation
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            controlableObject.Fly();
            statusController.SetStatusFly();

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            controlableObject.Shot();
            statusController.SetStatusShot();
        }
    }
}
