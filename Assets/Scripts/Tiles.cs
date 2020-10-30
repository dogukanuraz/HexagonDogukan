using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    //public Vector2 direction;
    public PolygonCollider2D polygonCollider;
    public GameObject threeTiles;
    private Vector2 firstTouchPosition;
    private Vector2 finalTouchPosition;
    private float swipeAngle;

    private void Start()
    {
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    void OnMouseDown()
    {
        polygonCollider.enabled = false;
        RaycastHit2D hitUp = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.up, 1.0f);
        RaycastHit2D hitDown = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.down, 1.0f);
        RaycastHit2D hitLeft = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.left, 1.0f);
        RaycastHit2D hitRight = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.right, 1.0f);

        GameObject triple = Instantiate(threeTiles, Camera.main.ScreenToWorldPoint(Input.mousePosition) * 1.2f, Quaternion.identity);
        this.transform.parent = triple.transform;

        if (hitUp.distance != 0)
        {
            if (hitDown.distance != 0)
            {
                if (hitUp.distance <= hitDown.distance)
                {
                    hitUp.transform.parent = triple.transform;
                }
                else
                {
                    hitDown.transform.parent = triple.transform;
                }
            }
            else
            {
                hitUp.transform.parent = triple.transform;
            }
        }
        else
        {
            hitDown.transform.parent = triple.transform;
        }

        if (hitLeft.distance != 0)
        {
            if (hitRight.distance != 0)
            {
                if (hitLeft.distance <= hitRight.distance)
                {
                    hitLeft.transform.parent = triple.transform;
                }
                else
                {
                    hitRight.transform.parent = triple.transform;
                }
            }
            else
            {
                hitLeft.transform.parent = triple.transform;
            }
        }
        else if (hitRight.distance != 0)
        {
            hitRight.transform.parent = triple.transform;
        }
        else
        {
            FindNearObject();
        }

        triple.name = "Three Objects";
    }
    
    void FindNearObject()
    {

    }


}
