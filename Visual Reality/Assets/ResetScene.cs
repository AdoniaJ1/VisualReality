using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetScene : MonoBehaviour
{
    public InputActionProperty leftSpecial;

    void Update()
    {
        if(leftSpecial.action.triggered)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

