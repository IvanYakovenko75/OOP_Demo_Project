using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusController : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI myText; 
    //public TMPro.TMP_Text myText;

    public TMP_Text status;

    private void Start()
    {

    }

    public void SetStatusFly()
    {
        status.text = "Ship is Fly";
    }

    public void SetStatusShot()
    {
        status.text = "Ship is Shot";
    }

    public void GiperJump()
    {
        status.text = "Ship is GiperJump";
    }

}
