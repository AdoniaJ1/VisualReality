using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void goBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
