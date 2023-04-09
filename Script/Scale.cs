using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private bool isScale;
    private float scaleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScale){
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        } 
            
            
       

    }
     public void ScaleObjek(float speed){
            isScale = true;
            scaleSpeed = speed;
            
        }
        public void StopScale(){
            isScale = false;
        }
}
