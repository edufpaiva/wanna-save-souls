using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScene : MonoBehaviour
{

    public string name = "intro";

    public void LoadScene() {
        GameManager.Instance.LoadScene(name);
    }

}
