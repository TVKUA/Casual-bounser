using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPrototype : MonoBehaviour
{
    [SerializeField]
    private Transform _targetBall;
    void Update()
    {
        transform.position = new Vector3(_targetBall.position.x, transform.position.y, transform.position.z);
    }
}
