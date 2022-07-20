using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public GameObject dragon;
    void Update ()
    {
      if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime *moveSpeed);
            dragon.transform.localRotation = Quaternion.Euler(0,270,0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            dragon.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
            dragon.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            dragon.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.W)  && Input.GetKey(KeyCode.D))
            dragon.transform.localRotation = Quaternion.Euler(0, 45, 0);
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            dragon.transform.localRotation = Quaternion.Euler(0, 135, 0);
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            dragon.transform.localRotation = Quaternion.Euler(0, 225, 0);
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            dragon.transform.localRotation = Quaternion.Euler(0, 315, 0);
    }
}
