using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetSkor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("skor",0);
       // PlayerPrefs.SetInt("benar",0);
      //  PlayerPrefs.SetInt("salah",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
