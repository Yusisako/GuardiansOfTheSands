using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {
		print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
			print("a");
            //If the GameObject has the same tag as specified, output this message in the console
			collision.gameObject.GetComponent<CharacterController>().enabled = false;
            collision.gameObject.transform.position = collision.gameObject.GetComponent<FPSController>().savepos;
			collision.gameObject.transform.rotation = collision.gameObject.GetComponent<FPSController>().saverotation;
			collision.gameObject.GetComponent<CharacterController>().enabled = true;
        }

    }
}
