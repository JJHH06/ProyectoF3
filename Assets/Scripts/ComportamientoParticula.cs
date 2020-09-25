﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoParticula : MonoBehaviour
{
    private double ESCALA = 1e15;


    public double campoElectricoPlaca = 0.0;
    public double velocidadInicial = 30.0;
    public double anguloDeTiro = 45.0;
 
    public int seleccion = 0;

    public GameObject[] particulas;

    // Start is called before the first frame update
    void Start()
    {

        //esto nos muestra visualmente la particula que se selecciono
        particulas[seleccion].SetActive(true);


        //Se coloca la velocidad inicial de la particula
        VelocidadInicial(velocidadInicial, anguloDeTiro);

        //Coloca el campo electrico a la placa
        SetCampoElectrico();

        


    }

    // Update is called once per frame
    void Update()
    {
        
    }



    /**
     * Esta funcion calcula las componentes de la velocidad inicial
     * basandose en la magnitud ingresada y el angulo
     **/
    private void VelocidadInicial(double magnitudVelocidad, double anguloGrados)
    {
        double anguloRadianes = Mathf.PI * anguloGrados / 180.0; //conversion del angulo de grados a radianes

        //componentes en X & Y de la velocidad
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3
            ((float)(magnitudVelocidad * Mathf.Cos((float)anguloRadianes) * (1e15)), //Componente en x de la velocidad a escala
            (float)(magnitudVelocidad * Mathf.Sin((float)anguloRadianes) * (1e15)), //Componente en y de la velocidad a escala
            0);
    }

    /**
     *Esta hace el set de la gravedad de la particula
     **/
    private void SetGravedadParticula(double gravedad)
    {
        Physics.gravity = new Vector3(0, (float)gravedad, 0);
    }

    /**
     * Este hace el calculo de la aceleracion basada en el campo electrico
     **/
    private double AceleracionCampo()
    {
        double carga = particulas[seleccion].GetComponent<PropiedadesParticula>().carga;
        double masa = particulas[seleccion].GetComponent<PropiedadesParticula>().masa;

         Debug.Log("masa" + masa);
         Debug.Log("carga" + carga);

         double result = ((carga * campoElectricoPlaca)/ masa);
         Debug.Log("\nresultado Aceleracion" + result);

        return result;
    }

    void SetCampoElectrico()
    {
        SetGravedadParticula(AceleracionCampo()*(ESCALA));
        Debug.Log(AceleracionCampo() * (ESCALA));
    }



}
