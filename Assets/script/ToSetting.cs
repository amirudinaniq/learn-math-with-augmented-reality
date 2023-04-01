using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSetting : MonoBehaviour
{

    private int currentSceneIndex;

    public void LoadSettingMenu()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //assign current index to this variable
        PlayerPrefs.SetInt("SavedScene", currentSceneIndex); //save the current scene in "SavedScene"  PlayerPrefs
        SceneManager.LoadScene(1); //go to setting scene
    }

}
