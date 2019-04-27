using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpawnObstacles : MonoBehaviour
{
    public int score = 0;
    public GameObject player;
    public GameObject[] blocks;
    public Sprite[] colors;
    public Sprite[] playerColors;
    public AnimationClip[] playerColorsAnimations; 
    public Text scoreDisplay;
    public GameObject gameOver;
    private string[] animations = { "blue-rocket", "green-rocket", "lime-rocket", "orange-rocket", "pink-rocket", "purp-rocket", "red-rocket", "turq-rocket", "yellow-rocket" };
    private Animator anim;
    private int randomInt; //!!!!!!!!!! вставить рандом инт из старт плеера.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    
    
    //Color[] colors = { new Color(153, 0, 0, 1), Color.blue, new Color(0, 153, 153, 1), new Color(0, 153, 0 ,1), new Color(255, 128, 0, 1), Color.magenta };
    //Color[] colors = {  };
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        anim = GetComponent<Animator>();
        if (other.name == "CurBlock")
        {
            score++;
//            var currentBaseState = player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
//            if (!currentBaseState.IsName("Default"))
//            {
//                print("yes");
//                //player.GetComponent<Animator>().speed += 200;   
//                player.GetComponent<Animator>().SetBool("Default", true);
//            }
//            //player.GetComponent<Animator>().
//            if (currentBaseState.IsName("Default"))
//            {
//                print("ura");
//            } 
            int randColor = Random.Range(0, animations.Length);
//          var srsrsr = animations[randColor];
            //player.GetComponent<Animator>().SetBool("isBlue", true);
            player.GetComponent<Animator>().Play(animations[randColor]);
            randomInt = randColor;
            
            //print(srsrsr);
            GenBlocks();
            //Destroy(player.GetComponent<Animation>());
            Destroy(GameObject.Find("CurBlock"));

        }
        else if (other.name != "CurBlock")
        {
            GameObject.Find("Main Camera").GetComponent<PlayerMovement>().speed = 0;
            Destroy(player);
            //print("Game over!");
            gameOver.SetActive(true);
            GameObject.Find("ScoreValue").GetComponent<Text>().text = score.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        randomInt = player.GetComponent<StartPlayer>().randomInt;
        GenBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
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
                        block.GetComponent<SpriteRenderer>().sprite = colors[randomInt];
                        print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        while (Array.IndexOf(colors, CheckColor()) == randColor)
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<SpriteRenderer>().sprite = colors[randColor];
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
                        block.GetComponent<SpriteRenderer>().sprite = colors[randomInt];
                        print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        //print("ref " + randColor);
                        //print(usedColors[0]);
                        while ((randColor == usedColors[0]) || (Array.IndexOf(colors, CheckColor()) == randColor))
                        {
                            //print("check1");
                            randColor = Random.Range(0, colors.Length);
                        }
                        
                        block.GetComponent<SpriteRenderer>().sprite = colors[randColor];
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
                        block.GetComponent<SpriteRenderer>().sprite = colors[randomInt];
                        print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        
                        while (((randColor == usedColors[0]) || (randColor == usedColors[1])) || (Array.IndexOf(colors, CheckColor()) == randColor))
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<SpriteRenderer>().sprite = colors[randColor];
                        usedColors.Add(randColor);
                        block.name = "block3";
                    }
                    block.tag = "Block";
                }
            }
    }

    Sprite CheckColor()
    {
        if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("blue-rocket"))
        {
            //print("blue");
            return colors[0];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("green-rocket"))
        {
            //print("green");
            return colors[1];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("lime-rocket"))
        {
            //print("lime");
            return colors[2];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("orange-rocket"))
        {
            //print("orange");
            return colors[3];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("pink-rocket"))
        {
            //print("pink");
            return colors[4];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("purp-rocket"))
        {
            //print("purp");
            return colors[5];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("red-rocket"))
        {
            //print("red");
            return colors[6];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("turq-rocket"))
        {
            //print("turq");
            return colors[7];
        } else if (player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("yellow-rocket"))
        {
            //print("yellow");
            return colors[8];
        }
        else
        {
            return colors[0];
        }
        //var currentBaseState = player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).shortNameHash;
        //var currentBaseState = player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).GetHashCode();
        //print(currentBaseState);
        //print(currentBaseState.ToString() + " " + Animator.StringToHash("isBlue").GetHashCode());
//        if (currentBaseState == Animator.StringToHash("isBlue"))
//        {
//            print("blue");
//            return colors[0];
//        } else if (currentBaseState == Animator.StringToHash("isGreen"))
//        {
//            print("green");
//            return colors[1];
//        } else if (currentBaseState == Animator.StringToHash("isLime"))
//        {
//            print("lime");
//            return colors[2];
//        } else if (currentBaseState == Animator.StringToHash("isOrange"))
//        {
//            print("pink");
//            return colors[3];
//        } else if (currentBaseState == Animator.StringToHash("isPink"))
//        {
//            print("pink");
//            return colors[4];
//        } else if (currentBaseState == Animator.StringToHash("isPurp"))
//        {
//            print("purp");
//            return colors[5];
//        } else if (currentBaseState == Animator.StringToHash("isRed"))
//        {
//            print("red");
//            return colors[6];
//        } else if (currentBaseState == Animator.StringToHash("isTurq"))
//        {
//            print("turq");
//            return colors[7];
//        } else if (currentBaseState == Animator.StringToHash("isYellow"))
//        {
//            print("yellow");
//            return colors[8];
//        }
//        else
//        {
//            return colors[0];
//        }
    }
}
