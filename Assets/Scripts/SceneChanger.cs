using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Scene Changer to link the buttons from the canvas panel to the next scene 
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GameScreen()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
