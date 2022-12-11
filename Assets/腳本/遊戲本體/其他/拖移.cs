using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 拖移 : MonoBehaviour
{

    Rigidbody2D Self;

    void Start()
    {
        Self = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //本體移動到滑鼠位置
         // Vector2 mouse = Input.mousePosition;
         // Self.transform.position = mouse;
        // Debug.Log("x: " + Self.transform.position.x + ", y: " + Self.transform.position.y);
    }

    // Vector2 handPosition
    public void movingPlayer( string A) {
        Debug.Log("movingPlayer: " + A);
        // Self.transform.position = handPosition;
        // Debug.Log("x: " + Self.transform.position.x + ", y: " + Self.transform.position.y);
    }
}
