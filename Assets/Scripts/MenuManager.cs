using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string loadGameSceneName;

    public void Exit()
    {
        Application.Quit();
    }
    public void loadGameSinglplayer()
    {
        SceneManager.LoadScene(loadGameSceneName);
    }
    public void loadGameMultiplayer()
    {

    }

}
