using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
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
    //public GameObject background;
    public Sprite[] playerColors;
    public AnimationClip[] playerColorsAnimations; 
    public Text scoreDisplay;
    public GameObject gameOver;
    public GameObject effect;
    public GameObject destroyEffect;
    private string[] animations = { "blue-rocket", "green-rocket", "lime-rocket", "orange-rocket", "pink-rocket", "purp-rocket", "red-rocket", "turq-rocket", "yellow-rocket" };
    private Animator anim;
    private int randomInt;
    private int usedRandomColor;
    private int usedRandBlock;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        destroyBlockEffect(other);
        
        anim = GetComponent<Animator>();
        if (other.name == "CurBlock")
        {
            score++;

            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().PlaySound("broke");
                
            int randColor = Random.Range(0, animations.Length);
            while (randColor == usedRandomColor)
            {
                randColor = Random.Range(0, animations.Length);
            }
            player.GetComponent<Animator>().Play(animations[randColor]);
            randomInt = randColor;
            usedRandomColor = randColor;
            GenBlocks();
            //if (score % 3 == 0) Instantiate(background, new Vector2(0, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
            Destroy(GameObject.Find("CurBlock"));

        }
        else if (other.name != "CurBlock")
        {
            Instantiate(destroyEffect, player.transform.position, Quaternion.identity);
            GameObject.Find("Main Camera").GetComponent<PlayerMovement>().speed = 0;
            GameObject.Find("Quad").GetComponent<PlayerMovement>().speed = 0;
            GameObject.Find("Quad").GetComponent<BackgroundMov>().speed = 0;
            GameObject.FindWithTag("Destroyer").GetComponent<PlayerMovement>().speed = 0;
            Destroy(player);

            //if ((GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting != true) && (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting == true)) GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().StopMusic();
            if ((GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().musicSetting == true) && (GameObject.Find("SettingsStorage").GetComponent<SettingsStorage>().soundSetting == true)) GameObject.FindGameObjectWithTag("MusicManager").GetComponent<MusicManager>().StopMusic();
            GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().PlaySound("lose");
            //print("Game over!");

            
            GameObject.Find("LiveScore").SetActive(false);
            GameObject.Find("Pause").SetActive(false);
            gameOver.SetActive(true);
            GameObject.Find("ScoreValue").GetComponent<Text>().text = score.ToString();
        }
    }  

    // Start is called before the first frame update
    void Start()
    {
        randomInt = player.GetComponent<StartPlayer>().randomInt;
        usedRandomColor = randomInt;
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
        while (rand == usedRandBlock)
        {
            rand = Random.Range(0, blocks.Length);
        }
        usedRandBlock = rand;
        List<int> usedColors = new List<int> {};
            for (int i = 0; i < blocks.Length; i++)
            {
                if (i == 0)
                {
                    //var block = Instantiate(blocks[i], new Vector2(-2.318f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    var block = Instantiate(blocks[i], new Vector2(-2.318f, GameObject.Find("Spawner").transform.position.y), Quaternion.identity);
                    if (rand == i)
                    {
                        block.GetComponent<SpriteRenderer>().sprite = colors[randomInt];
                        //print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        while (Array.IndexOf(colors, colors[randomInt]) == randColor)
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
                        //print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        //print("ref " + randColor);
                        //print(usedColors[0]);
                        while ((randColor == usedColors[0]) || (Array.IndexOf(colors, colors[randomInt]) == randColor))
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
                        //print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        
                        while (((randColor == usedColors[0]) || (randColor == usedColors[1])) || (Array.IndexOf(colors, colors[randomInt]) == randColor))
                        {
                            randColor = Random.Range(0, colors.Length);
                        }
                        block.GetComponent<SpriteRenderer>().sprite = colors[randColor];
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
                        block.GetComponent<SpriteRenderer>().sprite = colors[randomInt];
                        //print(randomInt);
                        usedColors.Add(Array.IndexOf(colors, colors[randomInt]));
                        block.name = "CurBlock";
                    }
                    else
                    {
                        int randColor = Random.Range(0, colors.Length);
                        
                        while (((randColor == usedColors[0]) || (randColor == usedColors[1]) || (randColor == usedColors[2])) || (Array.IndexOf(colors, colors[randomInt]) == randColor))
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

    void destroyBlockEffect(Collider2D other)
    {
        if (other.GetComponent<SpriteRenderer>().sprite.name == "blue_0")
        { 
            setEffect(new Color(0f/255f, 118f/255f, 255f/255f), other);
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "green_0")
        {
            setEffect(new Color(43f/255f, 155f/255f, 31f/255f), other); 
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "lime_0")
        {
            setEffect(new Color(110f/255f, 255f/255f, 43f/255f), other); 
        }
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "orange_0")
        {
            setEffect(new Color(255f/255f, 092f/255f, 0f/255f), other); 
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "pink_0")
        {
            setEffect(new Color(255f/255f, 51f/255f, 229f/255f), other); 
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "purp_0")
        {
            setEffect(new Color(130f/255f, 0f/255f, 255f/255f), other);  
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "red_0")
        {
            setEffect(new Color(255f/255f, 0f, 0f), other);  
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "turq_0")
        {
            setEffect(new Color(26f/255f, 255f/255f, 196f/255f), other);  
        } 
        else if (other.GetComponent<SpriteRenderer>().sprite.name == "yellow_0")
        {
            setEffect(new Color(255f/255f, 227f/255f, 0f), other);  
        }
        
    }

    void setEffect(Color color, Collider2D other)
    {
        if (other.name == "CurBlock")
        {
            var mainModule = effect.GetComponent<ParticleSystem>().main;
            //Color clr = new Color(43, 155, 31, 1);
            mainModule.startColor = color;
            Instantiate(effect, other.transform.position, Quaternion.identity);   
        }   
    }
}
