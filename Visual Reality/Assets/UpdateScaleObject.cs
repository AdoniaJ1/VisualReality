using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class UpdateScaleObject : MonoBehaviour
{
    public GameObject targetL;
    public GameObject targetR;
    public InputActionProperty leftSelect;
    public InputActionProperty rightSelect;
    private Vector3 lastPos;
    private Vector3 currentPos;
    public bool grabL; 
    

    // Start is called before the first frame update
    void OnEnable()
    {

        if(leftSelect.action.ReadValue<float>() > .1f){
            Vector3 lastPos = targetL.transform.localPosition;
            grabL = true;
        } else {
             Vector3 lastPos = targetR.transform.localPosition;
             grabL = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(grabL){
            currentPos = targetL.transform.localPosition;

            Debug.Log("Local Scale: "+ transform.localScale);
            Debug.Log("+");
            Debug.Log("Current Position R: "+ currentPos);
            Debug.Log("-");
            Debug.Log("Last Position R: "+ lastPos);
            Debug.Log("=");

            transform.localScale += (currentPos - lastPos);

            Debug.Log("Local Scale: "+ transform.localScale);
            Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            lastPos = currentPos;
        } else {
            currentPos = targetR.transform.localPosition;

            Debug.Log("Local Scale: "+ transform.localScale);
            Debug.Log("+");
            Debug.Log("Current Position R: "+ currentPos);
            Debug.Log("-");
            Debug.Log("Last Position R: "+ lastPos);
            Debug.Log("=");

            transform.localScale += (currentPos - lastPos);

            Debug.Log("Local Scale: "+ transform.localScale);
            Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            lastPos = currentPos;
        }
    }
}
