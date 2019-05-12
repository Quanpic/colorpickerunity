using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (speed <= 9.0f)
            {
                speed += 0.0015f - (player.GetComponent<SpawnObstacles>().score / 1000000.0f);
            }
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
