using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void GoHome()
    {
        //GameObject.FindGameObjectWithTag("MusicManager").GetComponent<AudioSource>().enabled = true;
        GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>().Stop();
        SceneManager.UnloadSceneAsync("Game");
        SceneManager.LoadScene("Menu");
    }
}
