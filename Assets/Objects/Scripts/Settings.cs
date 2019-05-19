using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    
    public void GoSettings()
    {
        MainMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
}
