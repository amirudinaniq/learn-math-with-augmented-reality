using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{

    // Time in seconds to delay (five seconds for example):
    

    public void LoadSceneByIndex()
    {

        Invoke("DelayedAction", 1f); ;
    }

    void DelayedAction()
    {
        SceneManager.LoadScene(11);
    }

    public void LoadSceneByIndex2()
    {

        Invoke("DelayedAction2", 1f); ;
    }

    void DelayedAction2()
    {
        SceneManager.LoadScene(13);
    }

    public GameObject crab;

    public void InactiveObject()
    {

        Invoke("DelayedAction3", 1f); ;
    }

    void DelayedAction3()
    {
        crab.SetActive(false);
    }

}
