using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void OpenDrive(){
        Application.OpenURL("https://drive.google.com/drive/folders/19IfQM318gS-84dN-daBiReECaCqtM_Fk?usp=sharing");
    }

}
