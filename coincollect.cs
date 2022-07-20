using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coincollect : MonoBehaviour
{
    public AudioSource collectFx;
    public GameObject Textscore;
    public static int coincount ;
    void OnTriggerEnter (Collider other)
    {
        
        if (other.tag == "Player")
        {
            collectFx.Play();
            coincount++;
            Textscore.GetComponent<Text>().text = ("Score :" + coincount); ;
            this.gameObject.SetActive(false);

        }
    }

}
