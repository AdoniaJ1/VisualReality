using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;


public class ActivateUIRay : MonoBehaviour
{
    public GameObject leftUI;
    public GameObject rightUI;


    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;

    

    // Update is called once per frame
    void Update()
    {
      leftUI.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>()>0.1f);
      rightUI.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() >0.1f);
    }
}
