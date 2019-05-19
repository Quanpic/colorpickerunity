using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoMainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    
    public void GoBack()
    {
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
