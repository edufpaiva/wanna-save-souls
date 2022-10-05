using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trofeu : MonoBehaviour
{

    public string fase;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.name.Contains("player")) {
            GameManager.Instance.LoadScene("1.1");
            Destroy(gameObject);
        
        }
    }


}
