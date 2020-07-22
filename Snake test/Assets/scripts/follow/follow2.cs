using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow2 : MonoBehaviour
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
        yield return new WaitForSeconds(1.2f);
        if (Player.position.z != transform.position.z)
        {
            transform.position = new Vector3(-3, 0, Player.position.z);
        }

    }
}
