using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{

    public GameObject[] blocks;
    public GameObject player;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    private float y = 4.719f;
    private GameObject curPlayer = GameObject.Find("Player");
    void Start()
    {
            int rand = Random.Range(0, blocks.Length);
            for (int i = 0; i < blocks.Length; i++)
            {
                if (i == rand) continue;
                Color[] colors = { Color.red, Color.blue, Color.cyan, Color.green };
                List<int> usedColors = new List<int> {};

                if (i == 0)
                {
                    var block = Instantiate(blocks[i], new Vector2(-2.318f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                    block.name = "block1";
                    usedColors.Add(randColor);
                }

                if (i == 1)
                {
                    var block = Instantiate(blocks[i], new Vector2(-0.78f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
                    if (colors[randColor] == colors[randColor])
                    {
                        
                    }
                    //if (randColor == usedColors[0]) randColor = Random.Range(0, colors.Length);
//                    {
//                        //randColor = Random.Range(0, colors.Length);
//                    }
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                    block.name = "block2";
                    usedColors.Add(randColor);
                }

                if (i == 2)
                {
                    var block = Instantiate(blocks[i], new Vector2(0.768f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
//                    if ((randColor == usedColors[0]) && (randColor == usedColors[1]))
//                    {
//                        //randColor = Random.Range(0, colors.Length);
//                    }
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                    block.name = "block3";
                    usedColors.Add(randColor);
                }

                if (i == 3)
                {
                    var block = Instantiate(blocks[i], new Vector2(2.318f, transform.position.y), Quaternion.identity);
                    int randColor = Random.Range(0, colors.Length);
//                    if ((randColor == usedColors[0]) && (randColor == usedColors[1]) && (randColor == usedColors[2]))
//                    {
//                        //randColor = Random.Range(0, colors.Length);
//                    }
                    block.GetComponent<Renderer>().material.color = colors[randColor];
                    block.name = "block4";
                    usedColors.Add(randColor);
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeBetweenSpawn <= 0)
        {
//            int rand = Random.Range(0, blocks.Length);
//            for (int i = 0; i < blocks.Length; i++)
//            {
//                if (i == rand) continue;
//                Color[] colors = { Color.red, Color.blue, Color.cyan, Color.green };
//                List<int> usedColors = new List<int> {};
//
//                if (i == 0)
//                {
//                    var block = Instantiate(blocks[i], new Vector2(-2.318f, transform.position.y), Quaternion.identity);
//                    int randColor = Random.Range(0, colors.Length);
//                    block.GetComponent<Renderer>().material.color = colors[randColor];
//                    block.name = "block1";
//                    usedColors.Add(randColor);
//                }
//
//                if (i == 1)
//                {
//                    var block = Instantiate(blocks[i], new Vector2(-0.78f, transform.position.y), Quaternion.identity);
//                    int randColor = Random.Range(0, colors.Length);
//                    if (colors[randColor] == colors[randColor])
//                    {
//                        
//                    }
//                    //if (randColor == usedColors[0]) randColor = Random.Range(0, colors.Length);
////                    {
////                        //randColor = Random.Range(0, colors.Length);
////                    }
//                    block.GetComponent<Renderer>().material.color = colors[randColor];
//                    block.name = "block2";
//                    usedColors.Add(randColor);
//                }
//
//                if (i == 2)
//                {
//                    var block = Instantiate(blocks[i], new Vector2(0.768f, transform.position.y), Quaternion.identity);
//                    int randColor = Random.Range(0, colors.Length);
////                    if ((randColor == usedColors[0]) && (randColor == usedColors[1]))
////                    {
////                        //randColor = Random.Range(0, colors.Length);
////                    }
//                    block.GetComponent<Renderer>().material.color = colors[randColor];
//                    block.name = "block3";
//                    usedColors.Add(randColor);
//                }
//
//                if (i == 3)
//                {
//                    var block = Instantiate(blocks[i], new Vector2(2.318f, transform.position.y), Quaternion.identity);
//                    int randColor = Random.Range(0, colors.Length);
////                    if ((randColor == usedColors[0]) && (randColor == usedColors[1]) && (randColor == usedColors[2]))
////                    {
////                        //randColor = Random.Range(0, colors.Length);
////                    }
//                    block.GetComponent<Renderer>().material.color = colors[randColor];
//                    block.name = "block4";
//                    usedColors.Add(randColor);
//                }
//                //int randColor = Random.Range(0, colors.Length);
//                //blocks[rand].GetComponent<Renderer>().material.color = Color.red;
//                //if (i == rand) Instantiate(blocks[i], new Vector2(2.318f, transform.position.y), Quaternion.identity);
//                //Instantiate(blocks[i], transform.position, Quaternion.identity);
//            }
            
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