using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berapa : MonoBehaviour
{
    public GameObject hasil,btn_back;
    // Start is called before the first frame update
    void Start()
    {
       
    }
  
    // Update is called once per frame
    void Update()
    {
        hasil.SetActive(true);
        btn_back.SetActive(true);
    }
}
