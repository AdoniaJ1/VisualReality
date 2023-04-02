using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonScaler : MonoBehaviour
{
    Vector3 change = new Vector3(0, 0, 0);
    float sizeInc = 0.1f;
    float sizeDec = -0.1f;

    public void XIncrementer()
    {
        change = new Vector3(sizeInc, 0,0);
        transform.localScale += change;
        Debug.Log("XIncrementer Called"+transform.localScale);
    }

    public void XDecrementer()
    {
        change = new Vector3(sizeDec, 0, 0);
        transform.localScale += change;
        Debug.Log("XDecrementer Called"+transform.localScale);
    }

    public void YIncrementer()
    {
        change = new Vector3(0, sizeInc, 0);
        transform.localScale += change;
    }

    public void YDecrementer()
    {
        change = new Vector3(0, sizeDec, 0);
        transform.localScale += change;
    }

    public void ZIncrementer()
    {
        change = new Vector3(0, 0, sizeInc);
        transform.localScale += change;
    }

    public void ZDecrementer()
    {
        change = new Vector3(0, 0, sizeDec);
        transform.localScale += change;
    }
 
}