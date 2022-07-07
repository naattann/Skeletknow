using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MuteScript : MonoBehaviour
{
    
    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Mute()
    {
        
        audioMixer.GetFloat("Master", out float vol);


        if (vol == -80f)
        {
            audioMixer.SetFloat("Master", 0f);
            
        }


        else
        {
            audioMixer.SetFloat("Master", -80f);
            
        }
    }
}
