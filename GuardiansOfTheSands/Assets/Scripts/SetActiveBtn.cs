using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveBtn : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveGameObject()
    {
        Object.SetActive(true);
    }
    
    public void DisableGameObject()
    {
        Object.SetActive(false);
    }
}
