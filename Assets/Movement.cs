using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float sped;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if(Keyboard.current.wKey.isPressed)
            rb.velocity += new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z).normalized * sped;
    }
}
