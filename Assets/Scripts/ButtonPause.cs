using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour{
  //the ButtonPauseMenu
    public GameObject PauseMenu;
    public GameObject OverMenu;
    public void OnPause()//点击“暂停”时执行此方法
    {
        PauseMenu.SetActive(true);
	    Debug.Log("On Pause");
    }
    public void OnResume()//点击“回到游戏”时执行此方法
    {
        PauseMenu.SetActive(false);
        Debug.Log("OnResume");
    }
    public void OnRestart()//点击“重新开始”时执行此方法
    {
        //  Loading Scene0
        // UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
        Debug.Log("OnRestart");

    }


    public void OnDestroy() {

        OverMenu.SetActive(false);
        
        SceneManager.LoadScene(1);

    }
}


