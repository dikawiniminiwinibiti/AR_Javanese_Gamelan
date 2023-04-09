using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{
    public AudioClip desc;
    public AudioClip gamelan;
    AudioSource audioso;
    // Start is called before the first frame update
    void Start()
    {
     audioso = GetComponent<AudioSource>();
     audioso.loop = false;
    }


    // Update is called once per frame
    public void Playsound(string audioName)
    {
        switch (audioName)
        {
            case "playdesc":
            audioso.clip = desc;
           
                break;
            case "playgamelan":
            audioso.clip = gamelan;
    
                break;
        }
         audioso.Play();
    }
}
