using UnityEngine;
using System.Collections;
using System;

public class Orchester : MonoBehaviour 
{
    public Animator alien;
    public Animator man;
    public GameObject player;

    public float fleeTime = 3;
    public float delay = 1;

    void endScene()
    {
        CharacterMotor motor = player.GetComponentInChildren<CharacterMotor>();
        motor.movement.maxForwardSpeed = 0.2f;
        motor.movement.maxSidewaysSpeed = 0.2f;
        motor.movement.maxBackwardsSpeed = 0.2f;
        StartCoroutine(endSceneCo());
    }
    IEnumerator endSceneCo()
    {
        yield return new WaitForSeconds(delay);
        iTween.MoveTo(alien.gameObject, iTween.Hash(
            "time", fleeTime,
            "orienttopath", true,
            "path", iTweenPath.GetPath("Flee")
        ));
        alien.SetTrigger("Flee");
        man.SetTrigger("Gun");
        iTween.ValueTo(this.gameObject, iTween.Hash(
            "time", 1,
            "from", 1,
            "to", 0.8f,
            "onupdate", (Action<object>) (v => Time.timeScale = (float)v)
            ));
    }

    void gunScene()
    {
        StartCoroutine(gunSceneCo());
    }
    IEnumerator gunSceneCo()
    {
        yield return new WaitForSeconds(2f);
        player.BroadcastMessage("die");
    }
}
