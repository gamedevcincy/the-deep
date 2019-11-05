using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplifiedPlayerController : MonoBehaviour
{

    float joystickDeadzone = .1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        bool grounded = IsGrounded();

        float magnitude = Input.GetAxis("Horizontal");
        if (Mathf.Abs(magnitude) > joystickDeadzone )
        {
            GetComponent<SimplifiedPlayerBehavior>().Move(magnitude);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            GetComponent<SimplifiedPlayerBehavior>().Jump();
        }
    }

    bool IsGrounded()
    {
        var col = GetComponent<CapsuleCollider>();
        float maxDistance = .2f;
        var origin = new Vector3(col.bounds.center.x, col.bounds.min.y + .05f, col.bounds.center.z);
        var result = Physics.Raycast(origin, Vector3.down, out RaycastHit hit, maxDistance);
        if(result)
            print(hit.collider.gameObject);
        Debug.DrawRay(origin, Vector3.down * maxDistance, Color.green);
        return result;
    }
}
