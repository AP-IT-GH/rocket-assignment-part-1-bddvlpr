using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehaviour : MonoBehaviour
{
    public Rigidbody physics;

    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space)) physics.velocity += transform.up * 1f;
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(0, 0, 1f);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(0, 0, -1f);
    }
}
