using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerScaler : MonoBehaviour
{
    public Vector3 size = new Vector3 (.2f,.2f,.2f);
    public Vector3 jump = new Vector3 (0f, 2.5f, 0f);
    float limitLo = .6f;
    float limitHi = 1.6f;
    // Start is called before the first frame update
    public void PlayerIncrementer()
    {
        if(transform.localScale.x < limitHi){
            transform.localScale += size;
            transform.localPosition += jump;
        }
    }

    // Update is called once per frame
    public void PlayerDecrementer() 
    {
        if(transform.localScale.x > limitLo){
            transform.localScale -= size;
            transform.localPosition += jump;
        }
    }

}
