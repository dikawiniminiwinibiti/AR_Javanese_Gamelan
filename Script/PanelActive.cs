using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;
    
    // Start is called before the first frame update
    public void OpenPanel(){
        if (Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    public void OpenButton(){
        if (Button != null){
            bool isActive = Button.activeSelf;
            Button.SetActive(!isActive);
        }}
    
}
