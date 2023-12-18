using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioClip coin;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<NotMario>())
        {
            col.GetComponent<NotMario>().AddCoin(coin);
            Destroy(gameObject);
        }
    }
}
