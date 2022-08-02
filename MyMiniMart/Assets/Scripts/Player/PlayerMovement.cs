using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private FloatingJoystick floatingJoystick;
    private Rigidbody rb;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 direction = Vector3.forward * floatingJoystick.Vertical + Vector3.right * floatingJoystick.Horizontal;
        rb.velocity = direction * speed;
        transform.LookAt(transform.position + new Vector3(floatingJoystick.Direction.x, 0, floatingJoystick.Direction.y));
    }

}
