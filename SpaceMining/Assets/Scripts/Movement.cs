using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int acceleration;
    private Vector2 direction = Vector2.up;
    private Vector3 oldPos = Vector3.zero;
    private Vector3 newPos = Vector3.zero;

    void FixedUpdate()
    {
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        
        rb.AddForce(direction * acceleration);

        oldPos = newPos;
        newPos = rb.position;

        Vector2 velocity = newPos - oldPos;
        direction = velocity.normalized;

        Debug.Log(direction);
    }
}
