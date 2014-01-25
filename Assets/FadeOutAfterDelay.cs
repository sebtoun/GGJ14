using UnityEngine;
using System.Collections;

public class FadeOutAfterDelay : MonoBehaviour {
    public float delay;
    public float time;
	// Use this for initialization

	void die() 
    {
        StartCoroutine(fadeOutCo());
	}

    IEnumerator fadeOutCo()
    {
        yield return new WaitForSeconds(delay);
        iTween.CameraFadeAdd();
        iTween.CameraFadeTo(1, time);
        yield return new WaitForSeconds(time);
        // TOTO CALLBACK
    }
}
