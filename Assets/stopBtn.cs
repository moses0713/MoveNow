using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopBtn : MonoBehaviour
{

    // Pause UI
    private bool isPause;
    private AudioSource bgMusicAudioSource;

    private GameObject[] arrowsL;
    private GameObject[] arrowsR;

    void Start()
    {
        isPause = false;
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("playBgMusic").GetComponent<AudioSource>();
        
    }

    public void PauseGame()
    {


        // 暫停
        Time.timeScale = 0;

        // 音樂暫停
        bgMusicAudioSource.Pause();

        // 左箭頭暫停
        arrowsL = GameObject.FindGameObjectsWithTag("arrowsL");
        foreach (GameObject L in arrowsL) {
            L.GetComponent<moveL>().enabled = false;
        }

        // 右箭頭暫停
        arrowsR = GameObject.FindGameObjectsWithTag("arrowsR");
        foreach (GameObject R in arrowsR) {
            R.GetComponent<moveR>().enabled = false;
        }
        Debug.Log("Time.timeScale: " + isPause + ", " + Time.timeScale);
    }

	public void onResume(){

	    Time.timeScale = 1;
        bgMusicAudioSource.Play();
        arrowsL = GameObject.FindGameObjectsWithTag("arrowsL");
        foreach (GameObject L in arrowsL) {
            L.GetComponent<moveL>().enabled = true;
        }

        arrowsR = GameObject.FindGameObjectsWithTag("arrowsR");
        foreach (GameObject R in arrowsR) {
            R.GetComponent<moveR>().enabled = true;
        }
	}
}
