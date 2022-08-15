using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public FloatingJoystick _joystick;
    public Rigidbody2D rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.up * _joystick.Vertical + Vector3.right * _joystick.Horizontal;
        rb.velocity = (direction * speed * Time.fixedDeltaTime);
    }
}
