using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private const string LOG = "GAME_MANAGER\t";


    public static GameManager Instance;

    public List<int> moedas = new List<int>();


    private void Awake() {
        DontDestroyOnLoad(gameObject);

        if(Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }

        moedas.Add(0);

    }


    public void AddCoin(int number) {

        Debug.Log(LOG + "ADD COIN   NUMBER: " + number);
        
        if(moedas.IndexOf(number) == -1) {
            moedas.Add(number);
        }
    }

    public bool IsCoinInList(int number) {

        Debug.Log(LOG + "IsCoinInList   NUMBER: " + number);
        Debug.Log(LOG + "IsCoinInList   MOEDAS: " + moedas.Contains(number));
        Debug.Log(LOG + "IsCoinInList   MOEDAS: " + moedas.IndexOf(number));

        foreach(int x in moedas) {
            Debug.Log(LOG + "IsCoinInList  FOR MOEDAS: " + x);
        }

        return moedas.IndexOf(number) != -1;
    }


    public void LoadScene(string name) {
        if(name == "intro") {
            moedas = new List<int>();
            moedas.Add(0);
        }

        SceneManager.LoadScene(name);
    }




}
