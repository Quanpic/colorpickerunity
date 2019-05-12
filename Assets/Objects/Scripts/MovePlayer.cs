using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MovePlayer : MonoBehaviour
{
    //public Transform player;
    private float speed = 0.33f;
    //private float deltaX;
    //private Rigidbody2D rb;
    //private Vector3 direction;


    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.6f, 2.6f), transform.position.y, transform.position.z);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchPos = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchPos.x * speed * Time.deltaTime, 0, 0);
        }
        
//        if (Input.touchCount > 0)
//        {
//            var touch = Input.GetTouch(0);
//            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
//
//          
//
////            if (touch.phase == TouchPhase.Ended)
////            {
////                rb.velocity = Vector2.zero;
////            }
//            switch (touch.phase)
//            {
//                case TouchPhase.Began:
//                    touchPos.z = 0;
//                    //deltaX = touchPos.x - transform.position.x;
//                    break;
//                case TouchPhase.Moved:
//                    if (touchPos.x > 2.6f) touchPos.x = 2.6f;
//                    if (touchPos.x < -2.6f) touchPos.x = -2.6f;
//                    direction.x = (touchPos.x - transform.position.x);
//                    rb.velocity = new Vector2(direction.x, direction.y) * (speed - Time.deltaTime);
//                    //rb.MovePosition(new Vector2(touchPos.x - deltaX, player.position.y));
//                    break;
//                case TouchPhase.Ended:
//                    rb.velocity = Vector2.zero;
//                    break;
//            }
//        }
    }

//    private void OnMouseDown()
//    {
//        if (!(GameObject.Find("Game Over")))
//        {
//            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - player.position.x;
//        }
//    }
//
//    private void OnMouseDrag()
//    {
//            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            if (mousePos.x > 2.6f) mousePos.x = 2.6f;
//            if (mousePos.x < -2.6f) mousePos.x = -2.6f;
//            if (!(GameObject.Find("Game Over")))
//            {
//                if (player)
//                {
//                    rb.velocity = new Vector2(mousePos.x, player.position.y) * (speed - Time.deltaTime);
////                    player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y),
////                        speed - Time.deltaTime);
//                }
//            }
//
//            //player.position = new Vector2(mousePos.x, player.position.y);
//    }
}
