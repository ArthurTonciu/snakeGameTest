using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightArrow();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftArrow();
        }

    }
    private void RightArrow()
    {
        if(transform.position.z != -2)
        {
            transform.position = new Vector3(0, 0, transform.position.z - 2);
        }
    }

    private void LeftArrow()
    {
        if (transform.position.z != 2)
        {
            transform.position = new Vector3(0, 0, transform.position.z + 2);
        }   
    }

    
}
