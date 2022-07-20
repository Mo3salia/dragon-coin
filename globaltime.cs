using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class globaltime : MonoBehaviour
{
    public GameObject timedisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject timeOuttext;
    public GameObject fadeOut;
    public GameObject player;
    
    void Update()
    {
        if (seconds==0&& levelcomplete.win==0)
        {
            player.GetComponent<playercontrol>().enabled = false; 
            timeOuttext.SetActive(true);
            fadeOut.SetActive(true);
            seconds = 0;
            coincollect.coincount = 0;
            StartCoroutine(Respawninglevel());
           
            
        }
        else 
        {
            if (deductingTime == false) {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
            
        }
    }
    IEnumerator DeductSecond ()
    {
        yield return new WaitForSeconds(1);
        seconds --;
        timedisplay.GetComponent<Text>().text = "time : "+seconds;
        deductingTime = false;
    }
    IEnumerator Respawninglevel ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(globalLevel.Levelnumber);
    }
}
