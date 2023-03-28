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
    private Vector3 lastPos = new Vector3();
    private Vector3 currentPos = new Vector3();
    public bool grabL; 
    //private Vector3 multi = new Vector3(1.5f,1.5f,1.5f);
    private Vector3 difference = new Vector3();
    

    // Start is called before the first frame update
    void OnEnable()
    {

        if(leftSelect.action.ReadValue<float>() > .1f){
             lastPos = targetL.transform.position;
             grabL = true;
        } else {
             lastPos = targetR.transform.position;
             grabL = false;
        }
        Debug.Log("Right Controller Position: "+  targetR.transform.position);
        Debug.Log("Initial Position: "+ lastPos);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(grabL){
            currentPos = targetL.transform.position;
            Debug.Log("Current Position "+ currentPos);
            Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Debug.Log("Local Scale: "+ transform.localScale);
            // Debug.Log("+");
            // Debug.Log("Current Position R: "+ currentPos);
            // Debug.Log("-");
            // Debug.Log("Last Position R: "+ lastPos);
            // Debug.Log("=");
            
            //public static Vector3 operator *(1.5f, Vector3 a);
            difference = (currentPos - lastPos);
            transform.localScale += (difference*multi);

            // Debug.Log("Local Scale: "+ transform.localScale);
            // Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            lastPos = currentPos;
        } else {
            currentPos = targetR.transform.position;
            Debug.Log("Current Position "+ currentPos);
            Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Debug.Log("Local Scale: "+ transform.localScale);
            // Debug.Log("+");
            // Debug.Log("Current Position R: "+ currentPos);
            // Debug.Log("-");
            // Debug.Log("Last Position R: "+ lastPos);
            // Debug.Log("=");
            difference = (currentPos - lastPos);
            transform.localScale += (difference * multi);

            //Debug.Log("Local Scale: "+ transform.localScale);
            //Debug.Log("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            lastPos = currentPos;
        }
    }
}
