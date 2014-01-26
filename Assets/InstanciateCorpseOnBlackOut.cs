using UnityEngine;
using System.Collections;

public class InstanciateCorpseOnBlackOut : MonoBehaviour 
{
    public GameObject corpse;
    void blackOut()
    {
        Instantiate(corpse, this.transform.position, Quaternion.identity);
    }
}
