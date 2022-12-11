using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newGameTimer", menuName = "CreateData/Create New GameTimerLists")]
public class GameSaveList : ScriptableObject//儲存容器
{
    public List<PointData> GameTimerLists;
}


[System.Serializable]//序列化(把資料變成可儲存的模式)
public class PointData//音符物件資料
{
    public float timer;//時間
    public int SquareID;//方向
    /*
    Square方向:
    0=End
    1=R1(0)    11=L1(0)
    2=R2(90)   12=L2(90)
    3=R3(180)  13=L3(180)
    4=R4(270)  14=L4(270)
    5=R5(45)   15=L5(45)
    6=R6(135)  16=L6(135)
    7=R7(225)  17=L7(225)
    8=R8(315)  18=L8(315)
     */
    public PointData()
    {

    }

    public PointData(int timer, int ID)
    {
        this.SquareID = ID;
    }
}
