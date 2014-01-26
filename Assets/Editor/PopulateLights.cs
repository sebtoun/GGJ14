using UnityEngine;
using UnityEditor;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;

public class PopulateLights : MonoBehaviour 
{
    public const string LIGHT_PREFIX = "light_";
    public const string ALARM_PREFIX = "alarme_";

    static Dictionary<string, GameObject> lights;
    static void init()
    {
        lights = Resources.LoadAll<GameObject>("lights").ToDictionary(go => go.name, go => go);
    }

    static void visitBFS(Transform transform, Func<Transform,bool> action, Func<Transform, bool> filter = null)
    {
        List<Transform> toContinue = new List<Transform>();
        foreach (Transform child in transform)
        {
            if (filter == null || filter(child))
            {
                if (action(child))
                    toContinue.Add(child);
            }
            else
                toContinue.Add(child);
        }
        foreach (Transform child in toContinue)
            visitBFS(child, action, filter);
    }


    [MenuItem("Populate Scene/Alarms")]
    static void populateAlarms()
    {
        if (lights == null)
            init();

        visitBFS(Selection.activeTransform, instanciateAlarm, tr => tr.name.StartsWith(ALARM_PREFIX));
    }

    [MenuItem("Populate Scene/Lights")]
    static void populateLights()
    {
        if (lights == null)
            init();

        visitBFS(Selection.activeTransform, instanciateLight, tr => tr.name.StartsWith(LIGHT_PREFIX));
    }


    static bool instanciateLight(Transform hook)
    {
        string lightType = hook.name.Substring(LIGHT_PREFIX.Length);
        Debug.Log(lightType);
        lightType = lightType.Substring(0, lightType.IndexOf('_'));
        GameObject light;
        if (lights.TryGetValue(lightType, out light))
        {
            GameObject lightObject = GameObject.Instantiate(light, hook.position, hook.rotation) as GameObject;
            foreach (Transform child in hook)
            {
                DestroyImmediate(child.gameObject);
            }
            lightObject.transform.parent = hook;
            return false;
        }
        else
        {
            Debug.LogError("light " + lightType + " not found");
            return true;
        }
    }

    static bool instanciateAlarm(Transform hook)
    {
        if (hook.GetComponent<Rotate>() == null)
            hook.gameObject.AddComponent<Rotate>();
        return false;
    }

    [MenuItem("Populate Scene/Lights", true)]
    static bool validatepopulateLights()
    {
        return Selection.activeTransform != null;
    }

    [MenuItem("Populate Scene/Alarms", true)]
    static bool validatepopulateAlarms()
    {
        return Selection.activeTransform != null;
    }

}
