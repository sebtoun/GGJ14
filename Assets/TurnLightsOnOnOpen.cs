using UnityEngine;
using System.Collections;

public class TurnLightsOnOnOpen : MonoBehaviour {
    public RandomLight[] lights;
    public float lightIntensityMod = 0.8f;
    public float delay = 1;
    void open()
    {
        StartCoroutine(openCo());
    }
    IEnumerator openCo()
    {
        foreach (var l in lights)
        {
            l.avgOn = 0.2f;
            l.avgOff = 0.1f;
            l.maxOn = 0.5f;
            l.maxOff = 0.3f;
        }
        yield return new WaitForSeconds(delay);
        foreach (var l in lights)
        {
            l.enabled = false;
            l.light.intensity = l.GetComponent<ChangeLightIntensityOnTrigger>().intensityOn * 0.8f;
        }
    }
}
