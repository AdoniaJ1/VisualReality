using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectScaler : MonoBehaviour
{
    public GameObject rightHand;
    

    private Vector3 originalScale;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        originalScale = transform.localScale;

        // Get the XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Add the Grab and Release event listeners

    }

    void Update()
    {

       transform.localScale = new Vector3(originalScale.x, originalScale.y + 0.1f, originalScale.z);

    }


}