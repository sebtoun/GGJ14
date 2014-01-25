using UnityEngine;
using System.Collections;

public class MotionBlurOnDeath : MonoBehaviour {
    void die()
    {
        GetComponent<MotionBlur>().enabled = true;
    }
}
