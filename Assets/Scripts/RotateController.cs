﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        this.transform.SetPositionAndRotation(this.transform.position, Quaternion.Euler(new Vector3(0,0,360)));
    }

}
