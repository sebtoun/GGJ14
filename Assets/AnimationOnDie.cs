using UnityEngine;
using System.Collections;

public class AnimationOnDie : MonoBehaviour 
{
    void die(RaycastHit collisionInfo)
    {
        Debug.Log(this.gameObject + " is dying");
        iTween.Stop(this.gameObject);
        GetComponent<Animator>().SetTrigger("Die");
    }
}
