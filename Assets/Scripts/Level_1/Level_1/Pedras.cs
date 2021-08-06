﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedras : MonoBehaviour
{
    GameObject pedra1, pedra2, pedra3;
    // Start is called before the first frame update
    void Start()
    {
        pedra1 = GameObject.Find("p1");
        pedra2 = GameObject.Find("p2");
        pedra3 = GameObject.Find("p3");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        pedra1.GetComponent<Rigidbody2D>().simulated = true;
        pedra2.GetComponent<Rigidbody2D>().simulated = true;
        pedra3.GetComponent<Rigidbody2D>().simulated = true;
    }
}
