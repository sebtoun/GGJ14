using UnityEngine;
using System.Collections;

public class FallOnDeath : MonoBehaviour
{
    Camera playerCamera;

    public GameObject headPrefab;

    void Start()
    {
        playerCamera = Camera.main;
    }

    void die()
    {
        Vector3 position = playerCamera.transform.position;
        Quaternion rotation = playerCamera.transform.rotation;

        GameObject head = Instantiate(headPrefab, position, rotation) as GameObject;
        //playerCamera.SendMessage("die");
        playerCamera.transform.parent = head.transform.Find("head");
        Destroy(this.gameObject);
        head.BroadcastMessage("die");
        head.GetComponentInChildren<Rigidbody>().AddTorque(new Vector3(0, 0, Mathf.Sign(Random.value - 0.5f)) * 3 + new Vector3(0, Random.value, Random.value) * 1, ForceMode.VelocityChange); 
    }
}
