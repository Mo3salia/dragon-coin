using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalLevel : MonoBehaviour
{
    public static int Levelnumber = 2;
    public int internalNum;

    // Update is called once per frame
    void Update()
    {
        internalNum = Levelnumber;
    }
}
