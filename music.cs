using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class music : MonoBehaviour
{
    [SerializeField] public GameObject MusicButton;

    [SerializeField] public Slider slider;
    [SerializeField] public Slider slider1;



    [SerializeField] public AudioClip clip;
    [SerializeField] public AudioSource audio;

    void Update()
    {
        audio.volume = slider.value;
    }


    public void offSaund()
        {
            if (audio.volume > 0)
            {
            slider.value = 0;
            slider1.value = 0;

            }
            else
            {
            slider.value = 1;
            slider1.value = 1;
            }
        } 
}
