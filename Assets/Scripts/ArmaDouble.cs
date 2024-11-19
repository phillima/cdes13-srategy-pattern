using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaDouble : Arma
{
    private Transform[] bulletPoints;

    private void Awake()
    {
        bulletPoints = new Transform[2];
    }

    // Start is called before the first frame update
    void Start()
    {
        bulletPoints[0] = GameObject.FindGameObjectWithTag("Left").transform;
        bulletPoints[1] = GameObject.FindGameObjectWithTag("Right").transform;
    }

    public override void Atirar()
    {
        Instantiate(municao,bulletPoints[0].position,Quaternion.identity);
        Instantiate(municao,bulletPoints[1].position,Quaternion.identity);
    }
}
