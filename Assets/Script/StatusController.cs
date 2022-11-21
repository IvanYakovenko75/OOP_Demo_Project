using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusController : MonoBehaviour
{
    //public TMPro.TextMeshProUGUI myText; 
    //public TMPro.TMP_Text myText;

    [SerializeField] private TMP_Text status;
    public TMP_Text Status //encapsulation
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }

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
