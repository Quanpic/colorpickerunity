using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject block;
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    
    // Start is called before the first frame update
    void Start()
    {
        //string[] colors = { "limeblock", "mblueblock", "orangeblock", "redblock" };
        Color[] colors = { Color.red, Color.blue, Color.yellow, Color.green };
        //Spawn1.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite = Resources.Load("Assets/Objects/Sprites/Blocks/" + colors[Random.Range(0, colors.Length)] + ".png", typeof(Sprite)) as Sprite;
        int rand = Random.Range(0, colors.Length);
        Spawn1.GetComponent<Spawn>().block.GetComponent<Renderer>().material.color = colors[rand];
        //var spriteRenderer = GetComponent<SpriteRenderer>();
        if ((Spawn1.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite == Spawn2.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite)
            && (Spawn1.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite == Spawn3.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite))
        {
            
        }
        //Spawn1.GetComponent<Spawn>().block.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Assets/Objects/Sprites/Block/limeblock.png");
        Instantiate(Spawn1.GetComponent<Spawn>().block, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
