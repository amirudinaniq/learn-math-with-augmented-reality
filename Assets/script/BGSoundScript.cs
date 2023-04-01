using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGSoundScript : MonoBehaviour {

    private Music music;
    public Button musicToggleButton;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite;


	// Use this for initialization
	void Start () {
        music = GameObject.FindObjectOfType<Music>();
        UpdateIconAndVolume();
	}

    void update()
    {

    }

    public void PauseMusic()
    {
        music.ToggleSound();
        UpdateIconAndVolume();
    }

    public void UpdateIconAndVolume()
    {
        if (PlayerPrefs.GetInt("Mute", 0) == 0)
        {
            AudioListener.volume = 1;
            musicToggleButton.GetComponent<Image>().sprite = musicOnSprite;
        }
        else
        {
            AudioListener.volume = 0;
            musicToggleButton.GetComponent<Image>().sprite = musicOffSprite;
        }
    }

/*
    //Play Global
    private static BGSoundScript instance = null;
    public static BGSoundScript Instance
    {
        get { return instance; }
    }


    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    void Update () {
		
	}*/
}
