using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //public GameObject pacman;
    //private Vector3 offset;

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = target.position + offset;

        transform.LookAt(target);

    }




}
