using UnityEngine;
using System.Collections;
using System;

public class HangerOpen : MonoBehaviour 
{
    GameObject door;
    private Vector3 open;
    public float stuckMovementHeight;
    public float openTime = 1;
    public float stuckTime = 0.2f;
    public float closeTime = 0.5f;
    public ParticleSystem[] particles;
    public int particlesCount = 10;
	void Start () 
    {
        door = transform.Find("porte_hangar").gameObject;
        open = door.transform.localPosition;
        door.transform.localPosition = Vector3.zero;
        openAnim();

	}
    void openAnim()
    { 
        iTween.MoveTo(door, iTween.Hash(
            "time", openTime,
            "position", open,
            "islocal", true,
            "easetype", iTween.EaseType.easeInQuad,
            "oncomplete", (Action<object>) (o => stuckAnim())
            ));
    }
    void stuckAnim()
    {
        foreach (var p in particles)
        {
            p.emissionRate = particlesCount;
        }
        iTween.MoveTo(door, iTween.Hash(
            "time", stuckTime / 2,
            "position", open + Vector3.down * stuckMovementHeight,
            "islocal", true,
            "oncomplete", (Action<object>) (o => 
                iTween.MoveTo(door, iTween.Hash(
                    "time", stuckTime / 2,
                    "position", open,
                    "islocal", true,
                    "oncomplete", (Action<object>)(go =>
                    {
                        closeAnim();
                        foreach (var p in particles)
                            p.emissionRate = 0;
                    })
                    )))
        ));
    }
    void closeAnim()
    {
        iTween.MoveTo(door, iTween.Hash(
            "time", closeTime,
            "position", Vector3.zero,
            "islocal", true,
            "easetype", iTween.EaseType.linear,
            "oncomplete", (Action<object>) (o => openAnim())
            ));
    }
}
