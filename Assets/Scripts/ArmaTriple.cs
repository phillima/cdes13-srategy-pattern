using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaTriple : Arma
{
    private Transform[] bulletPoints;
    // Start is called before the first frame update
    void Start()
    {
        bulletPoints = new Transform[3];
        bulletPoints[0] = GameObject.FindGameObjectWithTag("Central").transform;
        bulletPoints[1] = GameObject.FindGameObjectWithTag("Left").transform;
        bulletPoints[2] = GameObject.FindGameObjectWithTag("Right").transform;
    }

    
    public override void Atirar()
    {
        Instantiate(municao, bulletPoints[0].position, Quaternion.identity);
        Instantiate(municao, bulletPoints[1].position, Quaternion.identity);
        Instantiate(municao, bulletPoints[2].position, Quaternion.identity);
    }
}
