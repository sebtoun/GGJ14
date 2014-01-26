using UnityEngine;
using System.Collections;
using System;

public class InstantiateGun : MonoBehaviour {
    public GameObject gunPrefab;
    public Vector3 gunPosition;
    public float time = 0.8f;

    void pickUp(GameObject obj)
    {
        if (obj == null || obj.name == "gun")
        {
            gunPrefab.SetActive(true);
            Destroy(obj);
            iTween.MoveTo(gunPrefab, iTween.Hash(
                "time", time,
                "position", gunPosition,
                "islocal", true,
                "easetype", iTween.EaseType.easeOutQuad,
                "oncomplete", (Action<object>) (o => { gunPrefab.GetComponent<Recoil>().enabled = true; })
                ));
        }
    }
}
