using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;

    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > 2.6f) mousePos.x = 2.6f;
        if (mousePos.x < -2.6f) mousePos.x = -2.6f; 
        player.position = new Vector2(mousePos.x, player.position.y);
    }
}
