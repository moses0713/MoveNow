using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour{
  //the ButtonPauseMenu
    public GameObject ingameMenu;
    public void OnPause()//点击“暂停”时执行此方法
    {
        ingameMenu.SetActive(true);
	    Debug.Log("On Pause");
    }
    public void OnResume()//点击“回到游戏”时执行此方法
    {
        ingameMenu.SetActive(false);
        Debug.Log("OnResume");
    }
    public void OnRestart()//点击“重新开始”时执行此方法
    {
        //  Loading Scene0
        // UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        SceneManager.LoadScene("GameNow");
        Debug.Log("OnRestart");

    }
}


