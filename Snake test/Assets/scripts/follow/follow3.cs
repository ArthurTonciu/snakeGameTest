using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow3 : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        StartCoroutine(Test());
        
    }
    IEnumerator Test()
    {
        yield return new WaitForSeconds(1.6f);
        if (Player.position.z != transform.position.z)
        {
            transform.position = new Vector3(-4, 0, Player.position.z);
        }

    }
}
