using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    public float distance;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void OnMouseDown()
    {
        

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up)* distance, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position,Vector2.up);

        if (hit)
        {
            Debug.Log(hit.collider.name);
        }
    }

    
}
