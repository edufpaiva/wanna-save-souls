using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D col) {

        if(col.gameObject.name.Contains("moeda")) {

            string name = col.gameObject.name;

            name = name.Replace("moeda_", "");

            int number = 0;

            try {
                number = int.Parse(name);
            } catch {
                Debug.Log("ERROR  PARSE COIN NAME" + col.gameObject.name);
            }


            GameManager.Instance.AddCoin(number);
            Destroy(col.gameObject);
        }

    }




}
