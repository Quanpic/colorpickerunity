using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject[] blocks;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    private float y = 4.719f;

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, blocks.Length);
            for (int i = 0; i < blocks.Length; i++)
            {
                if (i == rand) continue;
                Color[] colors = { Color.red, Color.blue, Color.cyan, Color.green };

                if (i == 0)
                {
                    var block = Instantiate(blocks[i], new Vector2(-2.318f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                }

                if (i == 1)
                {
                    var block = Instantiate(blocks[i], new Vector2(-0.78f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                }

                if (i == 2)
                {
                    var block = Instantiate(blocks[i], new Vector2(0.768f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                }

                if (i == 3)
                {
                    var block = Instantiate(blocks[i], new Vector2(2.318f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                }
                //int randColor = Random.Range(0, colors.Length);
                //blocks[rand].GetComponent<Renderer>().material.color = Color.red;
                //if (i == rand) Instantiate(blocks[i], new Vector2(2.318f, transform.position.y), Quaternion.identity);
                //Instantiate(blocks[i], transform.position, Quaternion.identity);
            }
            
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (decreaseTime > 0.8)
            {
                //startTimeBetweenSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}