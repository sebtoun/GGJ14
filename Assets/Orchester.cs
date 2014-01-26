using UnityEngine;
using System.Collections;

public class Orchester : MonoBehaviour 
{
    public Animator alien;
    public Animator man;
    public GameObject player;

    public float fleeTime = 3;
    public float delay = 1;

    void endScene()
    {
        player.GetComponentInChildren<CharacterMotor>().enabled = false;
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
    }
}
