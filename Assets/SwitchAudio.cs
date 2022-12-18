using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAudio : MonoBehaviour
{

    private AudioSource bgMusicAudioSource;
    public AudioClip[] audios;

    private int choose_song_vari = 0;

    // Start is called before the first frame update
    void Start()
    {

        choose_song_vari = PlayerPrefs.GetInt("choose_song");
        Debug.Log("choose_song_vari: "+ choose_song_vari);
        //在所有Game Object中找尋Background Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("playBgMusic").GetComponent<AudioSource>();
        bgMusicAudioSource.clip = audios[choose_song_vari];
        this.gameObject.SetActive(false);
        this.gameObject.SetActive(true);
        // this.GetComponent<AudioSource>().clip = audios[choose_song_vari];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
