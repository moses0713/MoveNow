using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveLevelAndChangeScene : MonoBehaviour
{
    public int song;
    public void onClickToSaveLevel(int level) {
        string ScneneName = "πC¿∏•ª≈È";
        Debug.Log(ScneneName + " " + song + " " + level);
        PlayerPrefs.SetInt("choose_song", song);
        PlayerPrefs.SetInt("choose_level", level);

        Application.LoadLevel(ScneneName);
    }

    public void callTheNowStatus() {
        int choose_song_vari = PlayerPrefs.GetInt("choose_song");
        int choose_level_vari = PlayerPrefs.GetInt("choose_level");

        Debug.Log("callTheNowStatus: " + choose_song_vari + " " + choose_level_vari);
    }
}
