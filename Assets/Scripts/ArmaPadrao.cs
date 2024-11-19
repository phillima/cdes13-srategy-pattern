using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaPadrao : Arma
{
    Transform bulletPoint;
    private void Start()
    {
        bulletPoint = GameObject.FindGameObjectWithTag("Central").transform;
    }

    public override void Atirar()
    {
        Instantiate(municao,bulletPoint.position,Quaternion.identity);
    }
}
