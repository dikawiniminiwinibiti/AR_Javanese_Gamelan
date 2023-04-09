using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
 
    void Start()
    {
   
    }

 
    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt("skor").ToString();

    }
}
