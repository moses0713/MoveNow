using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveR : MonoBehaviour
{
    //方塊R

    Rigidbody2D SquareR;
    public ScoreSet Ans;

    int aa = 0;//辨識階段
    float createTime;

    void Start()
    {
        createTime = Time.time;
        Ans = ScoreSet.SSet;
        SquareR = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)//第一段偵測
    {
        Vector2 movel = SquareR.GetComponent<Transform>().position;
        if (movel.y < 270)
        {
            aa = 1;
            //Debug.Log("識別");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //觸碰消除
    {
        if (aa == 1)
        {
            //Debug.Log("消除成功");
            Ans.Set(true);//回傳"成功"
            Destroy(gameObject);//消除
        }
    }
    void Update()
    {

        Vector2 moveP = SquareR.GetComponent<Transform>().position;//方塊位置
        Vector2 moveL = SquareR.GetComponent<Transform>().localScale;//方塊大小

        if (moveP.y < 120)//自動消失 
        {
            Debug.Log("消除失敗");
            Debug.Log(Time.time - createTime);
            Ans.Set(false);//回傳"失敗"
            Destroy(gameObject);
        }
        else//移動
        {
            Vector2 movePP = new Vector2(moveP.x + 0.23f, moveP.y - 0.3f);
            Vector2 moveLL = new Vector2(moveL.x + 0.09f, moveL.y + 0.09f);
            SquareR.transform.position = movePP;
            SquareR.transform.localScale = moveLL;
        }
    }
}
