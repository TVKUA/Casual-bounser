using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private float moveInput;

    [SerializeField] 
    Joystick joystick;

    private Vector3 dir;

    void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        dir = new Vector3(moveInput, 0, 0);

        transform.Translate(dir * speed * Time.deltaTime);
    }
}
