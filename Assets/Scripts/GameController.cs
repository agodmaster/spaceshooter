using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public GameObject text;
    public EnemyBox box;

    public void GameOver() {
        text.SetActive(true);
        box.Stop();
    }
}
