using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Arma : MonoBehaviour
{
    [SerializeField]
    protected Municao municao;

    public abstract void Atirar();

}