using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] private float speedRotate; 
    // Start is called before the first frame update
    void Start()
    {
        speedRotate = Random.Range(0.3f, 1);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, speedRotate, 0);
    }
}
