using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Nave : MonoBehaviour
{
    [SerializeField]
    private Arma arma;

    Material naveMat;

    float dissolveTime = 4;
    
    private void Awake()
    {
        arma = Instantiate(arma, transform);
        naveMat = GetComponentInChildren<SpriteRenderer>().material;
    }

    private void Start()
    {
        //StartCoroutine(IEDissolve(0, 1.1f));
    }

    void OnAtirar(InputValue inputValue)
    {
        arma.Atirar();
    }

    IEnumerator IEDissolve(float origin, float target)
    {
        float elapdsedTime = 0;
        int dissolveProp = Shader.PropertyToID("_DissolveAmount");
        while (elapdsedTime < dissolveTime)
        {
            elapdsedTime += Time.deltaTime;
            //Desloca de origem até target
            float dissolveAmount = Mathf.Lerp(
                origin,
                target,
                elapdsedTime/dissolveTime);
            naveMat.SetFloat(dissolveProp,dissolveAmount);
            yield return null;
        }
        
        Destroy(gameObject);
    }
    
    public void SetArma(Arma arma)
    {
        // Destroy(this.arma);
        this.arma = Instantiate(arma);
        
    }
}
