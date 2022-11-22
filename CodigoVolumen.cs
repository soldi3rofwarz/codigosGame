using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoVolumen : MonoBehaviour
{

    public Slider slider;
    public float sliderValues;
    public Image mute;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 4f);
        AudioListener.volume = slider.value;
        CheckMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValues= valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValues);
        AudioListener.volume = slider.value;
        CheckMute();
    }
    public void CheckMute()
    {
        if(slider.value == 0)
        {
            mute.enabled = true;
        }
        else
        {
            mute.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
