using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMeun : MonoBehaviour
{
    public int loadlevel;
    public void StartGame()
    {
        globalLevel.Levelnumber = 2;
        SceneManager.LoadScene(globalLevel.Levelnumber);
    }
    public void LoadGame()
    {
        loadlevel = PlayerPrefs.GetInt("levelLoadNum");
        if (loadlevel <2)
        {
            SceneManager.LoadScene(globalLevel.Levelnumber);

        }
        else
        {
            globalLevel.Levelnumber = loadlevel;
            SceneManager.LoadScene(loadlevel);
        }
    }
    public void QuitGame()
    {
        
        Application.Quit();
    }
}
