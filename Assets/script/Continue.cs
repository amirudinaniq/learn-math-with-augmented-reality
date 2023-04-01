using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue: MonoBehaviour
{

    private int sceneToContinue;

    public void ContinueScene()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        SceneManager.LoadScene(sceneToContinue);
    }

}
