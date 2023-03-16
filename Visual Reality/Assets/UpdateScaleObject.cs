using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class UpdateScaleObject : MonoBehaviour
{
    public GameObject object2Scale;
    public GameObject leftHand;
    public GameObject rightHand;

    private Vector3 lastPosL;
    private Vector3 currPosL;
    private Vector3 lastPosR;
    private Vector3 currPosR;

    public InputActionProperty leftGrab;
    public InputActionProperty rightGrab;
    public InputActionProperty leftScale;
    public InputActionProperty rightScale;

    // Start is called before the first frame update
    void Start()
    {
        currPosL = leftHand.transform.localPosition;
        currPosR = rightHand.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        lastPosL = currPosL;
        currPosL = leftHand.transform.localPosition;
        lastPosR = currPosR;
        currPosR = rightHand.transform.localPosition;

        Debug.Log("Local Scale: "+ object2Scale.transform.localScale);
        Debug.Log("+");
        Debug.Log("Current Position R: "+ currPosR);
        Debug.Log("-");
        Debug.Log("Last Position R: "+ lastPosR);
        Debug.Log("=");

        object2Scale.transform.localScale += (currPosR - lastPosR);

        Debug.Log("Local Scale: "+ object2Scale.transform.localScale);
        Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    }
}
