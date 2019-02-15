using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    private float speed = 1f;
    private float deltaX;


    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    private void OnMouseDown()
    {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - player.position.x;
    }

    private void OnMouseDrag()
    {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x > 2.6f) mousePos.x = 2.6f;
            if (mousePos.x < -2.6f) mousePos.x = -2.6f;
            player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y),
            speed - Time.deltaTime);
            //player.position = new Vector2(mousePos.x, player.position.y);
    }
}
