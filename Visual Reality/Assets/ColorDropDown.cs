using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorDropDown : MonoBehaviour
{
    Renderer ren;

    public TMPro.TMP_Dropdown colorDrop;

    public void ColorSelector(){
        ren = GetComponent<Renderer>();
        
        if(colorDrop.value == 0)ren.material.color=Color.white;
        if(colorDrop.value == 1)ren.material.color=Color.black;
        if(colorDrop.value == 2)ren.material.color=Color.red;
        if(colorDrop.value == 3)ren.material.color=Color.blue;
        if(colorDrop.value == 4)ren.material.color=Color.yellow;
        if(colorDrop.value == 5)ren.material.color=Color.green;
        if(colorDrop.value == 6)ren.material.SetColor("_Color",new Vector4(1,.6f,.1f,1));
        if(colorDrop.value == 7)ren.material.SetColor("_Color",new Vector4(.588f,.4f,.1f,1));
    }
}