using UnityEngine;
using System.Collections;

public class HintAtStart : MonoBehaviour 
{
    public float time = 3;
    void Start () 
    {
        BroadcastMessage("showHint", "start");
        StartCoroutine(hideHintCo());
	}

    IEnumerator hideHintCo()
    {
        yield return new WaitForSeconds(time);
        BroadcastMessage("hideHint", "start");
    }
}
