using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCollisionToMenu : MonoBehaviour
{
    public Collider collider;
    public Toggle collisionToggle;
    public void Set(){
        //collider = collisionToggle.value
        collider.enabled = collisionToggle.isOn;
    }
}
