﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenuClick : MonoBehaviour
{
    private static int nbPause = 0;

    // Use this for initialization
    void Start()
    {

    }

    /// <summary>
    /// Save the progression. 
    /// TODO
    /// </summary>
    public void OnSave()
    {
        //TODO
    }

    /// <summary>
    /// Return to the main menu
    /// </summary>
    public void OnReturnMainMenu()
    {
        //TODO
    }

    /// <summary>
    /// Use when the user open the in game menu. 
    /// Open the menu, pause the game. Unlock the cursor.
    /// </summary>
    public void OnClickMenu()
    {
        if (gameObject.activeInHierarchy)
        {
            //The Menu is open, so we want to close it
            gameObject.SetActive(false);
            OptionMenuClick.UnPauseGame();
        }
        else
        {
            //The Menu is close, so we want to open it
            gameObject.SetActive(true);
            OptionMenuClick.PauseGame();
        }
        //TODO : Pause game, unlock cursor
    }

    /// <summary>
    /// Stantard procedur for paussing the game
    /// unLock the cursor and set timeScale to 0 (effectively pause all update)
    /// </summary>
    static public void PauseGame()
    {
        nbPause += 1;
        Debug.Log("Pause" + nbPause);
        if (nbPause > 0)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }

    /// <summary>
    /// Stantard procedure for unpaussing the game
    /// Lock cursor and set timeScale to 1
    /// </summary>
    static public void UnPauseGame()
    {
        nbPause -= 1;
        Debug.Log("UnPause" + nbPause);
        if (nbPause <= 0)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            nbPause = 0;
        }
    }
    /// <summary>
    /// Use when the user clik on the Quit menu button
    /// </summary>
    public void OnQuitGame()
    {

        Application.Quit();
    }
}
