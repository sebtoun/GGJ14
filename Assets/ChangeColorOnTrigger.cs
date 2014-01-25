using UnityEngine;
using System.Collections;

public class ChangeColorOnTrigger : MonoBehaviour 
{
    public Color onColor = Color.white;
    public Color offColor = Color.black;
    void turnOn()
    {
        renderer.sharedMaterial.color = onColor; 
    }

    void turnOff()
    {
        renderer.sharedMaterial.color = offColor; 
    }
}
