using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
      speed = Random.Range(20, 25);
    }


    void FixedUpdate()
    {
        transform.Translate(Vector3.up  * speed * Time.deltaTime);
    }
}
