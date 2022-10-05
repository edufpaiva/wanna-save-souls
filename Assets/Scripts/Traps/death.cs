using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    public int trapNumber;

    void Start()
    {
        if(!GameManager.Instance.IsCoinInList(trapNumber)) Destroy(gameObject);
    }

}
