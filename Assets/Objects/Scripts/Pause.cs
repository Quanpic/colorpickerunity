using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject Score;
    public GameObject PauseIcon;
    public Button PlayButton;
    public Button HomeButton;
    public Text PauseText;
    public GameObject Mov;
    private bool timerOn = false;
    private float currentTime = 0f;
    private float startingTime = 3f;
    public Text countdownText;
    
    public void PauseClick()
    {
        PauseMenu.SetActive(true);
        //Time.timeScale = 0f;
        //Mov.GetComponent<MovePlayer>().enabled = false; ///////////////
        StartStop(false);
        //Mov.SetActive(false);
        Score.SetActive(false);
        PauseIcon.SetActive(false);
    }

    public void PlayClick()
    {
        PauseText.enabled = false;
        //GameObject.Find("Play").SetActive(false);
        HomeButton.gameObject.SetActive(false);
        PlayButton.GetComponent<Image>().enabled = false;
        PlayButton.GetComponent<Button>().enabled = false;
        countdownText.GetComponent<Text>().enabled = true;
        countdownText.text = currentTime.ToString();
        timerOn = true;
    }
    

    void Start()
    {
        currentTime = startingTime;
        //Mov = GameObject.Find("Moving");
    }

    void Update()
    {
        if (timerOn == true)
        {
            currentTime -= 1 * Time.deltaTime;
           
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                PauseMenu.SetActive(false);
                //Time.timeScale = 1f;
                
                Score.SetActive(true);
                PauseIcon.SetActive(true);
                //Mov.GetComponent<MovePlayer>().enabled = true; ///////////////////
                //Mov.SetActive(true);
                StartStop(true);
                timerOn = false;
                currentTime = startingTime;
                countdownText.text = currentTime.ToString();
                countdownText.GetComponent<Text>().enabled = false;
                //PlayButton.gameObject.SetActive(true);
                PauseText.enabled = true;
                HomeButton.gameObject.SetActive(true);
                PlayButton.GetComponent<Image>().enabled = true;
                PlayButton.GetComponent<Button>().enabled = true;
            }
        }
    }
    
    
    void StartStop(bool val)
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerMovement>().enabled = val;
        GameObject.FindWithTag("Player").GetComponent<MovePlayer>().enabled = val;
        GameObject.FindWithTag("MainCamera").GetComponent<PlayerMovement>().enabled = val;
        GameObject.FindWithTag("Spawner").GetComponent<PlayerMovement>().enabled = val;
        GameObject.FindWithTag("Destroyer").GetComponent<PlayerMovement>().enabled = val;
//        GameObject.Find("Moving").GetComponent<PlayerMovement>().enabled = val;
        //GameObject.Find("Moving").GetComponent<MovePlayer>().enabled = val;
        GameObject.FindWithTag("Background").GetComponent<PlayerMovement>().enabled = val;
        GameObject.FindWithTag("Background").GetComponent<BackgroundMov>().enabled = val;
    }
}
