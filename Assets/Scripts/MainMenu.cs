using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Para la Navegación")]
    public GameObject inicio;
    public GameObject autores;
    public GameObject preparacion;

    [Space(10)]
    [Header("Para la lectura de datos")]
    public InputField velocidad;
    public InputField angulo_velocidad;
    public InputField magnitud_campo;
    public InputField n_particula;

    public void toInicio()
    {
        inicio.SetActive(true);
        autores.SetActive(false);
        preparacion.SetActive(false);
    }

    public void toAutores()
    {
        inicio.SetActive(false);
        autores.SetActive(true);
        preparacion.SetActive(false);
    }

    public void toPreparacion()
    {
        inicio.SetActive(false);
        autores.SetActive(false);
        preparacion.SetActive(true);
    }

    public void trySimulation()
    {
        Debug.Log("Verificando la información...");
        
        try
        { 
            //Data.datos.velocidad = double.Parse(velocidad.text);
            //Data.datos.angulo_velocidad = double.Parse(angulo_velocidad.text);
            //Data.datos.magnitud_campo = double.Parse(magnitud_campo.text);
            //Data.datos.n_particula = int.Parse(n_particula.text);

            toSimulacion();
        }
        catch
        {
            Debug.Log("Ahí algún error en los inputs.");
        }
    }

    private void toSimulacion()
    {
        Debug.Log("Se abrió la simulacion.");
        /*
        Debug.Log("Velocidad: " + Data.datos.velocidad);
        Debug.Log("Angulo: " + Data.datos.angulo_velocidad);
        Debug.Log("Campo: " + Data.datos.magnitud_campo);
        Debug.Log("Partícula: " + Data.datos.n_particula);
        */
    }

    public void exitGame()
    {
        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        
    }
}