using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{

    public TMPro.TMP_Dropdown sceneDrop;

    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
            }

   
   public void getDropdown()
    {
        if (sceneDrop.value ==0) {LoadScene("Main Scene");}
          if (sceneDrop.value ==1) {LoadScene("Table Scene");}
    }

    public void quit() {
        Application.Quit();

    }
}
