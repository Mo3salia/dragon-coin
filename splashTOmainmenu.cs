using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splashTOmainmenu : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(proceedTomenu());
    }
    IEnumerator proceedTomenu()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
    
}
