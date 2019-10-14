using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplifiedPlayerBehavior : MonoBehaviour
{
    public float maxMoveSpeed, accelerationSpeed, jumpSpeed;

    public void Move(float magnitude)
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(accelerationSpeed * Vector2.right * magnitude);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxMoveSpeed);
    }

    public void Jump()
    {
        var rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
    }
}
