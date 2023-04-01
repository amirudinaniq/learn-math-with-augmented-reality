using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class answer : MonoBehaviour
{

    public GameObject feed_betul;
    public GameObject feed_salah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void jawapan(bool jawab)
    {
        if(jawab)
        {
           feed_betul.SetActive(false);
            feed_betul.SetActive(true);
            int score = PlayerPrefs.GetInt("score") + 10;
            PlayerPrefs.SetInt("score", score);
        }
        else
        {
            feed_salah.SetActive(false);
            feed_salah.SetActive(true);
        }
        gameObject.SetActive(false);
        transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
