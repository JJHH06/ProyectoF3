using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmallMenu : MonoBehaviour
{

    public Slider slider;
    public Text textbox;

    void Start()
    {
        changeTimeScale(-10f);
    }

    private void changeTimeScale(float potencia)
    {
        Time.timeScale = Mathf.Pow(10, potencia);
        textbox.text = "Escala de Tiempo: " + Time.timeScale;
    }
    
    public void changeTimeScaleSlider()
    {
        changeTimeScale(slider.value);
    }
}
