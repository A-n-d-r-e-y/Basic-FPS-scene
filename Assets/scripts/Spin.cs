﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{

    public float speed = 3.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, speed, 0);
    }
}
