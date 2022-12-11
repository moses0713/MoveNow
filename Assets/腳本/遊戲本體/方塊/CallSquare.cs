using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSquare : MonoBehaviour
{
    //©I¥s¤è¶ôªº¦ì¸m

    public GameObject Rsquare;
    public GameObject Lsquare;

    void Start()
    {
        
    }
    public void CallR1()
    {
        Instantiate(Rsquare, new Vector3(700, 520, 0), Quaternion.Euler(0, 0, 0));
    }
    public void CallR2()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 90));
    }
    public void CallR3()
    {
        Instantiate(Rsquare, new Vector3(680, 520, 0), Quaternion.Euler(0, 0, 180));
    }
    public void CallR4()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 270));
    }
    //
    public void CallR5()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 45));
    }
    public void CallR6()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 135));
    }
    public void CallR7()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 225));
    }
    public void CallR8()
    {
        Instantiate(Rsquare, new Vector3(690, 520, 0), Quaternion.Euler(0, 0, 315));
    }










    public void CallL1()
    {
        Instantiate(Lsquare, new Vector3(600, 520, 0), Quaternion.Euler(0, 0, 0));
    }
    public void CallL2()
    {
        Instantiate(Lsquare, new Vector3(590, 520, 0), Quaternion.Euler(0, 0, 90));
    }
    public void CallL3()
    {
        Instantiate(Lsquare, new Vector3(580, 520, 0), Quaternion.Euler(0, 0, 180));
    }
    public void CallL4()
    {
        Instantiate(Lsquare, new Vector3(590, 520, 0), Quaternion.Euler(0, 0, 270));
    }
    public void CallL5()
    {
        Instantiate(Lsquare, new Vector3(600, 520, 0), Quaternion.Euler(0, 0, 45));
    }
    public void CallL6()
    {
        Instantiate(Lsquare, new Vector3(590, 520, 0), Quaternion.Euler(0, 0, 135));
    }
    public void CallL7()
    {
        Instantiate(Lsquare, new Vector3(580, 520, 0), Quaternion.Euler(0, 0, 225));
    }
    public void CallL8()
    {
        Instantiate(Lsquare, new Vector3(590, 520, 0), Quaternion.Euler(0, 0, 315));
    }
    private void Update()
    {


    }
}
