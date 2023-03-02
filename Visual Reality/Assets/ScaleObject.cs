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

    public InputActionProperty leftGrab;
    public InputActionProperty rightGrab;
    public InputActionProperty leftScale;
    public InputActionProperty rightScale;

    
    void Start(){

    }

    // Update is called once per frame
    void Update()
    {
        if((leftGrab.action.ReadValue<float>()>0.1f && leftScale.action.ReadValue<float>()>0.1f)){
            object2Scale.transform.localScale += leftHand.transform.localPosition;
        }
        if((rightGrab.action.ReadValue<float>()>0.1f && rightScale.action.ReadValue<float>()>0.1f)){
            object2Scale.transform.localScale += rightHand.transform.localPosition;;
        }
    }
}
