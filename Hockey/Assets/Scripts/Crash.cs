using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    [SerializeField]
    private Transform _ball;

    private float _minDistance = 0.5f;
    //private Object _explosion;

    void Start()
    {
        //_explosion = Resources.Load("Explosion");
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, _ball.position) < _minDistance)
        {
            Destroying();
        }
    }

    void Destroying()
    {
        /*GameObject _explosionRef = (GameObject)Instantiate(_explosion);
        _explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);*/
        Destroy(gameObject);
    }
}
