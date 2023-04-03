using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerScaler : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayerIncrementer()
    {
        transform.localScale += Vector3.one;
    }

    // Update is called once per frame
    public void PlayerDecrementer()
    {
        transform.localScale -= Vector3.one;
    }

}
