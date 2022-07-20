using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationspeed = 1.5f;
    void Update()
    {
        transform.Rotate(0, rotationspeed * Time.timeScale, 0, Space.World);
    }
}
