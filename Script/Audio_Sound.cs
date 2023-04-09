using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Sound : MonoBehaviour
{
    public AudioClip AKendhang, AKenong, ASlenthem, AGong, ABonang, ASaron;
    public AudioClip DKendhang, DKenong, DSlenthem, DGong, DBonang, DSaron;
    AudioSource audiosor;
    // Start is called before the first frame update
    void Start()
    {
     audiosor = GetComponent<AudioSource>();
     audiosor.loop = false;
    }


    // Update is called once per frame
    public void Playsound(string audioName)
    {
        switch (audioName)
        {
            case "kendhang":
            audiosor.clip = AKendhang;
           
                break;
            case "kenong":
            audiosor.clip = AKenong;
    
                break;

            case "slenthem":
            audiosor.clip = ASlenthem;
    
                break;
    
            case "gong":
            audiosor.clip = AGong;
    
                break;

            case "bonang":
            audiosor.clip = ABonang;
    
                break;

            case "saron":
            audiosor.clip = ASaron;
    
                break;
            case "dkendhang":
            audiosor.clip = DKendhang;
           
                break;
            case "dkenong":
            audiosor.clip = DKenong;
    
                break;

            case "dslenthem":
            audiosor.clip = DSlenthem;
    
                break;
    
            case "dgong":
            audiosor.clip = DGong;
    
                break;

            case "dbonang":
            audiosor.clip = DBonang;
    
                break;

            case "dsaron":
            audiosor.clip = DSaron;
    
                break;
        }
         audiosor.Play();
    }
}
