using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetUserInfo : MonoBehaviour {
    

    public void SetUserInformation(string ethinicity)
    {
        PlayerPrefs.SetString("ethinicity", ethinicity);
        SceneManager.LoadScene(1);
        Scene loadedScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        SceneManager.SetActiveScene(loadedScene);
    }
}
