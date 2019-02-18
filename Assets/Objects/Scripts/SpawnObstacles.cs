using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject player;
    public GameObject[] blocks;
    Color[] colors = { Color.red, Color.blue, Color.cyan, Color.green, Color.yellow, Color.magenta };
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "CurBlock")
        {
            int randColor = Random.Range(0, colors.Length);
            player.GetComponent<Renderer>().material.color = colors[randColor];
            GenBlocks();
            Destroy(GameObject.Find("CurBlock"));

        }
        else if (other.name != "CurBlock")
        {
            print("Game over!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GenBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenBlocks()
    {
        int rand = Random.Range(0, blocks.Length);
        List<int> usedColors = new List<int> {};
            for (int i = 0; i < blocks.Length; i++)
            {

                
                if (i == 0)
                {
                    var block = Instantiate(blocks[i], new Vector2(-2.318f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    if (rand == i)
                    {
                        block.GetComponent<Renderer>().material.color = player.GetComponent<Renderer>().material.color;
                        usedColors.Add(Array.IndexOf(colors, player.GetComponent<Renderer>().material.color));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        block.GetComponent<Renderer>().material.color = colors[randColor];
                        usedColors.Add(randColor);
                        block.name = "block1";
                    }
                    
                    block.tag = "Block";
                }

                if (i == 1)
                {
                    var block = Instantiate(blocks[i], new Vector2(-0.78f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    if (rand == i)
                    {
                        block.GetComponent<Renderer>().material.color = player.GetComponent<Renderer>().material.color;
                        usedColors.Add(Array.IndexOf(colors, player.GetComponent<Renderer>().material.color));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        while (randColor == usedColors[0])
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<Renderer>().material.color = colors[randColor];
                        usedColors.Add(randColor);
                        block.name = "block2";
                    }
                    block.tag = "Block";
                }

                if (i == 2)
                {
                    var block = Instantiate(blocks[i], new Vector2(0.768f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    if (rand == i)
                    {
                        block.GetComponent<Renderer>().material.color = player.GetComponent<Renderer>().material.color;
                        usedColors.Add(Array.IndexOf(colors, player.GetComponent<Renderer>().material.color));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        while ((randColor == usedColors[0]) && (randColor == usedColors[1]))
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<Renderer>().material.color = colors[randColor];
                        usedColors.Add(randColor);
                        block.name = "block3";
                    }
                    block.tag = "Block";
                }

                if (i == 3)
                {
                    var block = Instantiate(blocks[i], new Vector2(2.318f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    if (rand == i)
                    {
                        block.GetComponent<Renderer>().material.color = player.GetComponent<Renderer>().material.color;
                        usedColors.Add(Array.IndexOf(colors, player.GetComponent<Renderer>().material.color));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        while (randColor == usedColors[0] && (randColor == usedColors[1]) && (randColor == usedColors[2]))
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<Renderer>().material.color = colors[randColor];
                        usedColors.Add(randColor);
                        block.name = "block4";
                    }
                    block.tag = "Block";
                }
            }
    }
}
