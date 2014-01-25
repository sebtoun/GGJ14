using UnityEngine;
using System.Collections;

public class TurnLightsOnOnOpen : MonoBehaviour {
    public RandomLight[] lights;
    public float lightIntensityMod = 0.8f;
    void open()
    {
        foreach (var l in lights)
        {
            l.enabled = false;
            l.light.intensity = l.GetComponent<ChangeLightIntensityOnTrigger>().intensityOn * 0.8f;
        }
    }
}
