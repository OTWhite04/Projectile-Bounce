using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenusScript : MonoBehaviour
{
  
    public void PlayGame()
    {
        SceneManager.LoadScene("BounceProjectileOwen_Level1");
    }

    public void SettingsMenu()
    {
        SceneManager.LoadScene("ControlsScreen");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
