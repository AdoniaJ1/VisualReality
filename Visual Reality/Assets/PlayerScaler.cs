using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerScaler : MonoBehaviour
{
    public Vector3 minSize = new Vector3 (.2f,.2f,.2f);
    public Vector3 plusSize = new Vector3 (.2f,.2f,.2f);
    public Vector3 jump = new Vector3 (0f, 8f, 0f);
    float limitLo = .2f;
    float limitHi = 3f;
    // Start is called before the first frame update
    public void PlayerIncrementer()
    {
        if(transform.localScale.x < limitHi){
            transform.localScale += plusSize;
            transform.position = jump;
            Debug.Log(transform.position);
        }
    }

    // Update is called once per frame
    public void PlayerDecrementer() 
    {
        if(transform.localScale.x > limitLo){
            transform.localScale -= minSize;
            transform.position = jump;
            Debug.Log(transform.position);
        }
    }

}
