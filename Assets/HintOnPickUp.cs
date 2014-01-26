using UnityEngine;
using System.Collections;

public class HintOnPickUp : MonoBehaviour 
{
    public float time = 3;
    void pickUp(GameObject obj)
    {
        if (obj.name == "gun")
        {
            BroadcastMessage("showHint", "gun");
            StartCoroutine(hideHintCo());
        }
    }

    IEnumerator hideHintCo()
    {
        yield return new WaitForSeconds(time);
        BroadcastMessage("hideHint", "gun");
    }
}
