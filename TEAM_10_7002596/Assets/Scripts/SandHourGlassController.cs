using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SandHourGlassController : MonoBehaviour
{
    public float timeAdd = 30;

    void OnTriggerEnter(Collider collision)
    {
        //print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponentInChildren<TimeController>().leftTime += timeAdd;
            Destroy(gameObject);
        }

    }
}
