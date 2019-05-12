using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.UnloadSceneAsync("Game");
        SceneManager.LoadScene("Menu");
    }
}
