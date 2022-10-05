using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{


    public Vector3 newPosition;
    public Vector3 oldPosition;
    public float timeToUp = 1.5f;

    public Transform parentTransform;



    private void OnTriggerEnter2D(Collider2D col) {

        Debug.Log("TRIGGER COL " + col.gameObject.name);

        if(col.gameObject.name == "player") {
            parentTransform.position = Vector3.Lerp(oldPosition, newPosition, Time.deltaTime * timeToUp);
            Destroy(gameObject);
        }


    }
}
