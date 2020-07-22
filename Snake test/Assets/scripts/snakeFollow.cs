using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    const float followDistance = 1;

    void Update()
    {
        transform.position = target.position + (transform.position - target.position).normalized * followDistance;
    }
}
