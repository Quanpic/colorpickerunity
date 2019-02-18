using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Color[] colors = { Color.red, Color.blue, Color.cyan, Color.green, Color.yellow, Color.magenta  };
        int randColor = Random.Range(0, colors.Length);
        player.GetComponent<Renderer>().material.color = colors[randColor];
    }
}
