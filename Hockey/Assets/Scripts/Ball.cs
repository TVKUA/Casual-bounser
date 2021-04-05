using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _ballRigid;

    private bool _isPressed = false;
    private float _sensivityHor = 9f;
   
    
    void Start()
    {
        _ballRigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(_isPressed == true)
        {
            _ballRigid.position = Input.mousePosition;
        }

        transform.Rotate(0, Input.GetAxis("Mouse X") * _sensivityHor , 0);
        
    }

    private void OnMouseDown()
    {
        _isPressed = true;
        _ballRigid.isKinematic = true;
    }

    private void OnMouseUp()
    {
        _isPressed = false;
        _ballRigid.isKinematic = false;
    }
}
