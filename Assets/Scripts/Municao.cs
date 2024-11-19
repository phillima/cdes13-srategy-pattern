using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municao: MonoBehaviour
{
    [SerializeField] private float velocidade;
    // Start is called before the first frame update

    private Rigidbody2D municaoRb;
    
    [SerializeField]
    GameObject municaoVFX;
    
    private void Awake()
    {
        municaoRb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        municaoRb.velocity = new Vector2(velocidade, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        //StartCoroutine(IETeste());
        GameObject municaoVFXGO = Instantiate(municaoVFX,transform.position,Quaternion.identity);
        Destroy(municaoVFXGO, 1);
       
    }

    IEnumerator IETeste()
    {
        print("Comecou co-rotina");
        yield return new WaitForSecondsRealtime(1);
        print("Terminou co-rotina");
        
        
    }
    
}
