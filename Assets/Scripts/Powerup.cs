using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private Arma arma;

    private Rigidbody2D puRb;

    private void Awake()
    {
        puRb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        puRb.velocity = new Vector2(-2,0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponentInParent<Nave>() != null)
        {
            print("Colisao com a nave!");
            Nave nave = other.GetComponentInParent<Nave>();
            nave.SetArma(arma);
        }
    }

    
}
