using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteGame : CallSquare
{
    private int SquareID = -999;//���ID

    public AudioSource bgm;//����

    public Slider bgmslider;//timeline

    private bool dragSlider = false;

    public GameSaveList GameList;//�x�s��m

    private void Start()//�}�l-������
    {
        bgm.Pause();
    }
    void OnClickPlay()//���ֶ}�l�Ȱ�
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (bgm.isPlaying)
            {
                bgm.Pause();
                Debug.Log(GameList.GameTimerLists.ToString());
            }
            else
            {
                bgm.Play();
            }
        }
    }


    void Update()
    {
        OnClickPlay();

        //����timeline
        if (!dragSlider)
        {
            bgmslider.value = bgm.time / bgm.clip.length;// now/length
        }
        else
        {
            bgm.time = bgmslider.value * bgm.clip.length;
        }

/////////////////////////////////////////////////////////L 
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 11;
            CallL1();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 12;
            CallL2();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 13;
            CallL3();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 14;
            CallL4();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 15;
            CallL5();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 16;
            CallL6();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 17;
            CallL7();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Debug.Log("Call Lsquare");
            SquareID = 18;
            CallL8();
            AddPoint(SquareID, bgm.time);
        }
        /////////////////////////////////////////////////////////R
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 1;
            CallR1();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 2;
            CallR2();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 3;
            CallR3();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 4;
            CallR4();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 5;
            CallR5();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 6;
            CallR6();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 7;
            CallR7();
            AddPoint(SquareID, bgm.time);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            //Debug.Log("Call Rsquare");
            SquareID = 8;
            CallR8();
            AddPoint(SquareID, bgm.time);
        }


        if (bgmslider.value == 1)//***�ʩ�***
        {
            AddPoint(0, bgm.time + 1);
        }


        if (Input.GetKeyDown(KeyCode.I))//����ɶ�
        {
            bgm.time = bgm.time + 10;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            bgm.time = bgm.time - 10;
        }
    }

    private void AddPoint(int SquareId, float currentTime)
    {
        PointData pNode = new PointData();//���Ū���
        pNode.timer = currentTime;
        pNode.SquareID = SquareId;
        //pNode.gameObject = Instantiate(pointPre);//���ӬO���?

        GameList.GameTimerLists.Add(pNode);
    }

}




