using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Controls_test : MonoBehaviour
{
    public InputActionProperty rightHandInteractionActivate;
    public InputActionProperty rightHandInteractionActivateValue;
    public InputActionProperty rightHandInteractionRotateAnchor;
    public InputActionProperty rightHandInteractionSelect;
    public InputActionProperty rightHandInteractionSelectValue;
    public InputActionProperty rightHandInteractionTranslateAnchor;
    public InputActionProperty rightHandInteractionUIPress;
    public InputActionProperty rightHandInteractionUIPressValue;
    public InputActionProperty rightHandLocomotionGrabMove;
    public InputActionProperty rightHandLocomotionGrab;
    public InputActionProperty rightHandLocomotionMove;
    public InputActionProperty rightHandLocomotionSnapTurn;
    public InputActionProperty rightHandLocomotionTeleportDirection;
    public InputActionProperty rightHandLocomotionTeleportModeActivate;
    public InputActionProperty rightHandLocomotionTeleportModeCancel;
    public InputActionProperty rightHandLocomotionTeleportSelect;
    public InputActionProperty rightHandLocomotionTurn;
    public InputActionProperty rightHandHapticDevice;
    public InputActionProperty rightHandPosition;
    public InputActionProperty rightHandRotation;
    public InputActionProperty rightHandTrackingState;
    public InputActionProperty rightHandUIRightClick;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (rightHandInteractionRotateAnchor.action.ReadValue<float>() > 0.1f)   {
            Debug.Log(rightHandInteractionRotateAnchor);
        }

        if (rightHandInteractionRotateAnchor.action.ReadValue<float>() > 0.1f)   {
            Debug.Log(rightHandInteractionRotateAnchor);
        }

        if (rightHandInteractionSelect.action.ReadValue<float>() > 0.1f)   {
            Debug.Log(rightHandInteractionSelect);
        }

        if (rightHandInteractionSelect.action.ReadValue<float>() > 0.1f)   {
            Debug.Log(rightHandInteractionSelect);
        }

        if (rightHandInteractionSelectValue.action.ReadValue<float>() > 0.1f) {
            Debug.Log(rightHandInteractionSelectValue);
        }

        if (rightHandInteractionTranslateAnchor.action.ReadValue<float>() > 0.1f) {
            Debug.Log(rightHandInteractionTranslateAnchor);
        }

        if (rightHandInteractionUIPress.action.ReadValue<float>() > 0.1f) {
            Debug.Log(rightHandInteractionUIPress);

        }

        if (rightHandInteractionUIPressValue.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandInteractionUIPressValue);

        }
        if (rightHandLocomotionGrabMove.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionGrabMove);

        }
        if (rightHandLocomotionGrab.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionGrab);

        }

        if (rightHandLocomotionMove.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionMove);

        }

        if (rightHandLocomotionSnapTurn.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionSnapTurn);

        }

        if (rightHandLocomotionTeleportDirection.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionTeleportDirection);

        }

        if (rightHandLocomotionTeleportModeActivate.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionTeleportModeActivate);

        }

        if (rightHandLocomotionTeleportModeCancel.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionTeleportModeCancel);

        }

        if (rightHandLocomotionTeleportSelect.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionTeleportSelect);

        }
        if (rightHandLocomotionTurn.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandLocomotionTurn);

        }

        if (rightHandPosition.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandPosition);

        }

        if (rightHandRotation.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandRotation);

        }
        if (rightHandTrackingState.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandTrackingState);

        }

        if (rightHandUIRightClick.action.ReadValue<float>() > 0.1f) {

            Debug.Log(rightHandUIRightClick);

        }

    }






}
