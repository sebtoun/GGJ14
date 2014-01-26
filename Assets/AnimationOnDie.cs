using UnityEngine;
using System.Collections;

public class AnimationOnDie : MonoBehaviour 
{
    void die(RaycastHit collisionInfo)
    {
        iTween.Stop(this.gameObject);
        GetComponent<Animator>().SetTrigger("Die");
        SendMessageUpwards("gunScene");
    }
}
