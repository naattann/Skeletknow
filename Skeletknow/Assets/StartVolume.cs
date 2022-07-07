using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;




public class StartVolume : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private string category;
 



    private void Start()
    {

        audioMixer.SetFloat(category, PlayerPrefs.GetFloat(category) - 80f);

    }

}
