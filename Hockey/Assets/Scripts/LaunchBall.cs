using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        /*Vector3 ScreenmousePosition = Input.mousePosition;
        Vector3 WorldmousePosition = Camera.main.ScreenToWorldPoint(ScreenmousePosition);
        Debug.Log(ScreenmousePosition);
        transform.LookAt(ScreenmousePosition);*/

    }

}
