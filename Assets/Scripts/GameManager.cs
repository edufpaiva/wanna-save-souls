using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    private List<int> moedas = new List<int>();


    private void Awake() {
        if(Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }

        moedas.Add(0);

    }


    public void AddCoin(int number) {
        if(!moedas.Contains(number)) {
            moedas.Add(number);
        }
    }

    public bool IsCoinInList(int number) {
        return moedas.Contains(number);
    }

}
