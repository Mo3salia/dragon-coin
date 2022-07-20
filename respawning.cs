using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class respawning : MonoBehaviour
{
    
    void Start()
    {
        SceneManager.LoadScene(globalLevel.Levelnumber);
        coincollect.coincount = 0;
    }

   
}
