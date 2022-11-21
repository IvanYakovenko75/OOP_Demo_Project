using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusController : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI myText; 
    //public TMPro.TMP_Text myText;

    public TMP_Text status; //{ get; set}

    //[SerializeField] private TMP_Text statusText { get; set}


    public void SetStatusFly()
    {
        status.text = "Ship is Fly";
    }

    public void SetStatusShot()
    {
        status.text = "Cruiser is Laser Shot";
    }

    public void SetGiperJump()
    {
        status.text = "Cruiser is GiperJump";
    }

}
