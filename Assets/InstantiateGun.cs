using UnityEngine;
using System.Collections;

public class InstantiateGun : MonoBehaviour {
    public GameObject gunPrefab;
    void pickUp(GameObject obj)
    {
        if (obj.name == "gun")
        {
            gunPrefab.SetActive(true);
            Destroy(obj);
        }
    }
}
