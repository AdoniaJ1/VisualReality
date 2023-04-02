using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnerScript : MonoBehaviour
{

    public InputActionProperty rightSpecial;


    public GameObject cubePrefab;
    void Update()
    {
        if(rightSpecial.action.ReadValue<float>() > .1f)
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }
    }
}
