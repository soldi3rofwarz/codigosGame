using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoBrillo : MonoBehaviour
{
    public Slider Slider;
    public float sliderValue;
    public Image panelBrillo;

    // Start is called before the first frame update
    void Start()
    {
        Slider.value = PlayerPrefs.GetFloat("brillo", 0.2f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, Slider.value);
    }

    public void CambiarBrillo(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, Slider.value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
