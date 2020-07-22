using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
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
        yield return new WaitForSeconds(0.4f);
        if (Player.position.z != transform.position.z)
        {
            transform.position = new Vector3(-1, 0, Player.position.z);
        }
        
    }
}
