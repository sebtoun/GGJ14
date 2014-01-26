using UnityEngine;
using System.Collections;

public class InstanciateCorpseOnBlackOut : MonoBehaviour 
{
    public GameObject corpse;
    void blackOut()
    {
        Vector3 pos = this.transform.position;
        pos.y = 0;
        Instantiate(corpse, pos, Quaternion.identity);
    }
}
