using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform : MonoBehaviour
{
	public char axis = 'x';
	public float speed = 0.01f;
	public float lengthmovement = 3f;
	public float delay = 0;
	private int multiplier = 1;
	private float moved = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (delay <= 0){
			if (multiplier * moved >= lengthmovement){
				multiplier *= -1;
			}
			if (axis == 'x'){
				transform.position = new Vector3(transform.position.x + speed * multiplier, transform.position.y, transform.position.z);
			}
			if (axis == 'y'){
				transform.position = new Vector3(transform.position.x, transform.position.y + speed * multiplier, transform.position.z);
			}
			if (axis == 'z'){
				transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * multiplier);
			}
			
			moved += speed * multiplier;
		}
		else{
			delay -= speed;
		}
    }
}
