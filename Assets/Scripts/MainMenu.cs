using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
        SceneManager.LoadScene("PERU");
    }

    public void GameInfo(){
        SceneManager.LoadScene("Info");
    }

    public void ExitGame(){
        Application.Quit();
    }
}
