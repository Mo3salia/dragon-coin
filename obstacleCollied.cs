using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class obstacleCollied : MonoBehaviour
{
    
    
    public static int coincount;
    public GameObject obstacletext;
    public GameObject fadeOut;
    public GameObject player;
    void OnTriggerEnter (Collider other)
    {
       
        if (other.tag == "Player")
        {

            player.GetComponent<playercontrol>().enabled = false;
            obstacletext.SetActive(true);
            fadeOut.SetActive(true);
            coincollect.coincount = 0;
            StartCoroutine(Respawninglevel());

        }
    }
    IEnumerator Respawninglevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(globalLevel.Levelnumber);
    }
}
