using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObject : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Find("WinLose").GetComponent<WinLose>().Win();
            Destroy(gameObject);
        }

    }
}
