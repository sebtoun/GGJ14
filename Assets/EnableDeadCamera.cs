using UnityEngine;
using System.Collections;

public class EnableDeadCamera : MonoBehaviour 
{
    GameObject deadCam;
    void Start()
    {
        deadCam = transform.Find("deadCam").gameObject;
    }
    void blackOut()
    {
        deadCam.SetActive(true);
    }
}
