using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnerScript : MonoBehaviour
{

    public InputActionProperty rightSpecial;
    public TMPro.TMP_Dropdown shapeDropDown;

    public GameObject shapePrefab;
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;
    public GameObject cylinderPrefab;

    void Update()
    {
        if(rightSpecial.action.triggered)
        {
            if(shapeDropDown.value == 0) shapePrefab = cubePrefab;
            if(shapeDropDown.value == 1) shapePrefab = spherePrefab;
            if (shapeDropDown.value == 2) shapePrefab = capsulePrefab;
            if (shapeDropDown.value == 3) shapePrefab = cylinderPrefab;

            Instantiate(shapePrefab, transform.position, Quaternion.identity);
        }
    }
    public void setCustomSpawn(GameObject selectedObject)
    {
        shapePrefab = selectedObject;
    }
}
