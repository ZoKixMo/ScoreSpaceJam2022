using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public Rigidbody2D ownRb;
    private Rigidbody2D targetRb;
    public GameObject targetGameObject;

    private void Start()
    {
        targetRb = targetGameObject.GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        Attract();
    }
    
    void Attract()
    {
        Vector2 direction = ownRb.position - targetRb.position;
        float distance = direction.magnitude;

        float forceMagnitude = (ownRb.mass * targetRb.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        targetRb.AddForce(force);
    }
    

    /*
    const float G = 1f;

    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        Attraction[] attractors = FindObjectsOfType<Attraction>();
        foreach(Attraction attraction in attractors)
        {
            if(attraction != this)
            {
                Attract(attraction);
            }
        }
    }

    void Attract(Attraction objToAttract)
    {
        Rigidbody2D rbToAttract = objToAttract.rb;

        Vector2 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
    */
}
