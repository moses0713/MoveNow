using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallGame : CallSquare//繼承呼叫方塊
{
    [Header("軌道時刻表文件")]
    public GameSaveList GameListIn;//關卡


    public GameObject OverMenu;
    

    public GameSaveList[] GameListIns = new GameSaveList[12];//關卡

    public AudioSource bgm;//音樂

    public float delay;

    public Slider bgmslider;//timeline
    private bool dragSlider = false;

    int SquareID=0;

    float timer=0;

    int Nowset=0;//第幾個元素

    private List<PointData> GameList = new List<PointData>();

    private int choose_song_vari = 0;
    private int choose_level_vari = 0;

    private void Start()
    {
        SquareID = GameListIn.GameTimerLists[Nowset].SquareID;//第一個音符
        timer = GameListIn.GameTimerLists[Nowset].timer;
        //Debug.Log("Set:" + timer);

        choose_song_vari = PlayerPrefs.GetInt("choose_song");
        choose_level_vari = PlayerPrefs.GetInt("choose_level");
        GameListIn = GameListIns[choose_song_vari * 3 + choose_level_vari]; // [1 , 2] = [5]

    }

    public void Renew()//更新下一個方塊資料
    {
        
        if (GameListIn.GameTimerLists[Nowset+1].SquareID!=0)
        {
            Nowset++;
            SquareID = GameListIn.GameTimerLists[Nowset].SquareID;
            timer = GameListIn.GameTimerLists[Nowset].timer;
            //Debug.Log("Set:"+timer);
        }
        else
        {
            timer = bgm.time + 1;
            SquareID = 0;
        }
    }

    private void Update()
    {
        if (!dragSlider)//時間條
        {
            bgmslider.value = bgm.time / bgm.clip.length;// now/length
        }
        else
        {
            bgm.time = bgmslider.value * bgm.clip.length;
        }

        if (bgmslider.value == 1)
        {

            OverMenu.SetActive(true);

        }

        if (bgm.time+delay >= timer)//呼叫方塊
            {
                //Debug.Log("Now:"+bgm.time);
                if (SquareID == 1)
                {
                    CallR1();
                }
                if (SquareID == 2)
                {
                    CallR2();
                }
                if (SquareID == 3)
                {
                    CallR3();
                }
                if (SquareID == 4)
                {
                    CallR4();
                }
                if (SquareID == 5)
                {
                    CallR5();
                }
                if (SquareID == 6)
                {
                    CallR6();
                }
                if (SquareID == 7)
                {
                    CallR7();
                }
                if (SquareID == 8)
                {
                    CallR8();
                }


            if (SquareID == 11)
                {
                    CallL1();
                }
                if (SquareID == 12)
                {
                    CallL2();
                }
                if (SquareID == 13)
                {
                    CallL3();
                }
                if (SquareID == 14)
                {
                    CallL4();
                }
            Renew();
            }
        
    }
    /*
    private void AddPoint(int SquareId, float currentTime)
    {
        PointData pNode = new PointData();//音符物件
        pNode.timer = currentTime;
        pNode.SquareID = SquareId;
        //callSquare

        GameList.Add(pNode);
    }


    private void Update()
    {
        foreach (var point in GameList)
        {
            //(400 * point.p, (this.bgm.currentTime - (point.t / 1000)) * -1500, 0);//1500
            point.gameObject.transform.position = new Vector3(point.trackId, (bgm.time - point.timer) * -15, 0);//20  1.00
        }
    }
    */
}
