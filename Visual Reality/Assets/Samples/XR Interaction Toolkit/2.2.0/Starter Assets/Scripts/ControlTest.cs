using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTest : MonoBehaviour
{
    publicInputInteractionProperty rightHandInteractionActivate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rightHandInteractionActivate.action.ReadValue<float>()>0.1f){
            Debug.log(rightHandInteractionActivate);
        }
    }
}
