using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleObject : MonoBehaviour
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

    
    void Start(){
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
        Debug.Log("Right Controller Position: " + currPosR);
        
        if((leftGrab.action.ReadValue<float>()>0.1f && leftScale.action.ReadValue<float>()>0.1f)){
            object2Scale.transform.localScale += (currPosL - lastPosL);
        }
        if((rightGrab.action.ReadValue<float>()>0.1f && rightScale.action.ReadValue<float>()>0.1f)){
            object2Scale.transform.localScale += (currPosR - lastPosR);
            Debug.Log("Intended Scale" + object2Scale.transform.localScale);
        }
    }
}
