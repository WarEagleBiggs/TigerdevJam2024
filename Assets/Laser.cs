using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        transform.Rotate(0,3 * speed * Time.deltaTime,0);
    }
}
