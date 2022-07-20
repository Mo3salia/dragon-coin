using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcomplete : MonoBehaviour
{
    public int importedcoins;
    public static int win = 0;
    public GameObject levelcompletetext;
    public GameObject fadeOut;
    public GameObject player;

    void Update()
    {
        importedcoins = coincollect.coincount;
        if (importedcoins==7)
        {
            win = 1;
            StartCoroutine(Levelcomplete());

        }
    }
    IEnumerator Levelcomplete()
    {
        yield return new WaitForSeconds(0.5f);
        levelcompletetext.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<playercontrol>().enabled = false;
        yield return new WaitForSeconds(3);
        globalLevel.Levelnumber += 1;
        if (globalLevel.Levelnumber > 4)
        {
            SceneManager.LoadScene(1);
            PlayerPrefs.SetInt("levelLoadNum", 2);
            coincollect.coincount = 0;
        }
        else
        {
            SceneManager.LoadScene(globalLevel.Levelnumber);
            PlayerPrefs.SetInt("levelLoadNum", globalLevel.Levelnumber);
            coincollect.coincount = 0;
           
        }
        win = 0;
    }
}
