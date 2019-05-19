using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        //GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().enabled = true;
        //GameObject.FindWithTag("Background").GetComponent<PlayerMovement>().enabled = true;
        
        GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().volume = 0.5f;
    }
}
