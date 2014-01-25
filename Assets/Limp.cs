using UnityEngine;
using System.Collections;

public class Limp : MonoBehaviour {
    public AnimationClip clip;
    public float movementThreshold = 1;
    CharacterController controller;
	// Use this for initialization
	void Start () {
        clip.wrapMode = WrapMode.Once;
        animation.clip = clip;
        controller = GameObject.FindObjectOfType<CharacterController>();
	}

    float movementAmount;

    // Update is called once per frame
	void Update () {
        movementAmount += controller.velocity.magnitude * Time.deltaTime;
        if (movementAmount >= movementThreshold)
        {
            if (!animation.isPlaying)
                animation.Play();
            movementAmount -= movementThreshold;
        }
    }
}
