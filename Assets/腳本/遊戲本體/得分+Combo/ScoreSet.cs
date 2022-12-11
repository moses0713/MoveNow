using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSet : MonoBehaviour
{
    public Combo Combo;//呼叫Combo物件
    public int ComboX;//Combo加成設定值
    public static ScoreSet SSet;
    const float max = 100;//Combo條max值

    int now = 0;//Combo數
    float nowCombo=0;//加成率
    int score = 0;//分數

    void Start()
    {
        SSet = this;
        Combo.Initialize(now, max);
        now = 0;
        nowCombo = 0;
        score = 0;
    }

/// //////////////////////////////////////////////

    public void Set(bool set) //傳入結果
    {
        if (set == true)//成功
        {
            now++;//Combo數++
            int a = now/ ComboX;//加成率ex.27combo/5=5加成
            if (a > nowCombo & nowCombo<10)//加成率不超過10
            {
                nowCombo++;//增加Combo率
                add();//增加Combo率(顯示)
            }
            Combo.SetCombo(now);//Combo數(顯示)
            Score();
        }


        if (set == false)//失敗
        {
            now = 0;//Combo數歸零
            nowCombo = 0;//清除Combo率
            clear();//清除Combo率(顯示)
            Combo.SetCombo(now);//更改Combo數(顯示)
        }
    }
/// //////////////////////////////////////////////
    public void add()//增加Combo率(顯示)
    {
        Combo.UpdateState(nowCombo*10, max);//更改combo條(顯示)
    }
    public void clear()//清除Combo率(顯示)
    {
        Combo.UpdateState(now, max);
    }
    /// //////////////////////////////////////////////
    public void Score()
    {
        if (nowCombo == 0)
        {
            score+=10;
            Combo.SetScore(score);//更改分數(顯示)
        }
        else
        {
            score += (now / ComboX) * 100;
            Combo.SetScore(score);
        }

    }

 /// //////////////////////////////////////////////
    void Update()//測試
    {
        if (Input.GetKeyDown("i"))
        {
            //Debug.Log("Combo add");
            add();
        }
        if (Input.GetKeyDown("o"))
        {
            //Debug.Log("Combo clear");
            clear();
        }
    }
}
