using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveR : MonoBehaviour
{
    //���R

    Rigidbody2D SquareR;
    public ScoreSet Ans;

    int aa = 0;//���Ѷ��q
    float createTime;

    void Start()
    {
        createTime = Time.time;
        Ans = ScoreSet.SSet;
        SquareR = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)//�Ĥ@�q����
    {
        Vector2 movel = SquareR.GetComponent<Transform>().position;
        if (movel.y < 270)
        {
            aa = 1;
            //Debug.Log("�ѧO");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) //Ĳ�I����
    {
        if (aa == 1)
        {
            //Debug.Log("�������\");
            Ans.Set(true);//�^��"���\"
            Destroy(gameObject);//����
        }
    }
    void Update()
    {

        Vector2 moveP = SquareR.GetComponent<Transform>().position;//�����m
        Vector2 moveL = SquareR.GetComponent<Transform>().localScale;//����j�p

        if (moveP.y < 120)//�۰ʮ��� 
        {
            Debug.Log("��������");
            Debug.Log(Time.time - createTime);
            Ans.Set(false);//�^��"����"
            Destroy(gameObject);
        }
        else//����
        {
            Vector2 movePP = new Vector2(moveP.x + 0.23f, moveP.y - 0.3f);
            Vector2 moveLL = new Vector2(moveL.x + 0.09f, moveL.y + 0.09f);
            SquareR.transform.position = movePP;
            SquareR.transform.localScale = moveLL;
        }
    }
}
