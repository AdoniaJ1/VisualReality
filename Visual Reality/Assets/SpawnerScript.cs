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

    void Update()
    {
        if(rightSpecial.action.triggered)
        {
            if(shapeDropDown.value == 0) shapePrefab = cubePrefab;
            if(shapeDropDown.value == 1) shapePrefab = spherePrefab;

            Instantiate(shapePrefab, transform.position, Quaternion.identity);
        }
    }
}
