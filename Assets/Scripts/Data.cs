using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data datos;
    public double velocidad;
    public double angulo_velocidad;
    public double magnitud_campo;
    public int n_particula;

    void Awake()
    {
        if (Data.datos == null)
            Data.datos = this;
        else if (Data.datos != this)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this);
    }

}
