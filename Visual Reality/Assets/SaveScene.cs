using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class SaveScene : MonoBehaviour
{

    public InputActionProperty leftSpecial;

    void Update()
    {
        if(leftSpecial.action.triggered)
        {
            // Get the name of the current scene
            string sceneName = SceneManager.GetActiveScene().name;

            // Create a new scene with a unique name
            string newSceneName = sceneName + "_saved_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
            Scene newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            newScene.name = newSceneName;

            // Copy all the objects in the current scene to the new scene
            foreach (GameObject obj in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                GameObject newObj = Instantiate(obj);
                newObj.transform.SetParent(null);
                newObj.transform.position = obj.transform.position;
                newObj.transform.rotation = obj.transform.rotation;
                newObj.transform.localScale = obj.transform.localScale;
                newObj.SetActive(obj.activeSelf);
                newObj.name = obj.name;
                SceneManager.MoveGameObjectToScene(newObj, newScene);
            }

            // Save the new scene
            EditorSceneManager.SaveScene(newScene, "Assets/Scenes/" + newSceneName + ".unity");
        }
        
        }
    public void SaveCurrentScene()
    {
        // Get the name of the current scene
        string sceneName = SceneManager.GetActiveScene().name;

        // Create a new scene with a unique name
        string newSceneName = sceneName + "_saved_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss");
        Scene newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        newScene.name = newSceneName;

        // Copy all the objects in the current scene to the new scene
        foreach (GameObject obj in SceneManager.GetActiveScene().GetRootGameObjects())
        {
            GameObject newObj = Instantiate(obj);
            newObj.transform.SetParent(null);
            newObj.transform.position = obj.transform.position;
            newObj.transform.rotation = obj.transform.rotation;
            newObj.transform.localScale = obj.transform.localScale;
            newObj.SetActive(obj.activeSelf);
            newObj.name = obj.name;
            SceneManager.MoveGameObjectToScene(newObj, newScene);
        }

        // Save the new scene
        EditorSceneManager.SaveScene(newScene, "Assets/Scenes/" + newSceneName + ".unity");
    }
}