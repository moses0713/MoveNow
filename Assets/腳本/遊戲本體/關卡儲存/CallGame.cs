using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallGame : CallSquare//�~�өI�s���
{
    [Header("�y�D�ɨ����")]
    public GameSaveList GameListIn;//���d


    public GameObject OverMenu;
    

    public GameSaveList[] GameListIns = new GameSaveList[12];//���d

    public AudioSource bgm;//����

    public float delay;

    public Slider bgmslider;//timeline
    private bool dragSlider = false;

    int SquareID=0;

    float timer=0;

    int Nowset=0;//�ĴX�Ӥ���

    private List<PointData> GameList = new List<PointData>();

    private int choose_song_vari = 0;
    private int choose_level_vari = 0;

    private void Start()
    {
        SquareID = GameListIn.GameTimerLists[Nowset].SquareID;//�Ĥ@�ӭ���
        timer = GameListIn.GameTimerLists[Nowset].timer;
        //Debug.Log("Set:" + timer);

        choose_song_vari = PlayerPrefs.GetInt("choose_song");
        choose_level_vari = PlayerPrefs.GetInt("choose_level");
        GameListIn = GameListIns[choose_song_vari * 3 + choose_level_vari]; // [1 , 2] = [5]

    }

    public void Renew()//��s�U�@�Ӥ�����
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
        if (!dragSlider)//�ɶ���
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

        if (bgm.time+delay >= timer)//�I�s���
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
        PointData pNode = new PointData();//���Ū���
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
