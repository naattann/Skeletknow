using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;




public class AudioVolume : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private string category;
    public Slider volumeSlider;



    private void Start()
    {
     
        volumeSlider.value = PlayerPrefs.GetFloat(category);
        audioMixer.SetFloat(category, volumeSlider.value - 80f);

    }
    // Start is called before the first frame update
    public void ChangeVolume()
    {

        audioMixer.SetFloat(category, volumeSlider.value - 80f);
        PlayerPrefs.SetFloat(category, volumeSlider.value);

    }

    
}
