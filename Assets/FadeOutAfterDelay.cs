using UnityEngine;
using System.Collections;

public class FadeOutAfterDelay : MonoBehaviour {
    public float delay;
    public float time;

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
        SendMessageUpwards("blackOut");
    }
}
