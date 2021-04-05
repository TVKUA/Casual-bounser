using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
 
    void Update()
    {
        
        /*if (transform.position.z < 1.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.5f);
        }*/
       
        /*transform.LookAt(_target);
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);*/
        


        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);     
    }
}
