using UnityEngine;
using System.Collections;

public class ChangeLightIntensityOnTrigger : MonoBehaviour {
    public float intensityOn;
    public float intensityOff;
    void turnOn()
    {
        light.intensity = intensityOn;
    }

    void turnOff()
    {
        light.intensity = intensityOff;
    }
}
