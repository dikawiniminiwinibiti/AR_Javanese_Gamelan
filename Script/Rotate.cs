using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 10;
    private string sumbu;
    private bool putar;
    //public Vector3 rotation;


    void Update()
    {
        if (putar){

            //sumbu y , vector3.up = vector3(0,1,0)
            if(sumbu.ToUpper().Equals("Y")){
                transform.Rotate(Vector3.up * speed, Space.Self);
     
            }
            if(sumbu.ToUpper().Equals("-Y")){
                transform.Rotate(Vector3.up * -speed, Space.Self);
            }

            }
            }


    public void Rotatoe(string sumbu){
        this.sumbu = sumbu;
        putar = true;

    }

    public void StopDonk(){

        putar = false;
    }
}
