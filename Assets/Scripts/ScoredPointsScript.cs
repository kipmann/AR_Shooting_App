using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dieses Skript dient zur Anzeige der anschliessenden Beschriftung mit den Punkten, wenn das Spiel beendet ist
public class ScoredPointsScript : MonoBehaviour {

    public GameObject textDiplay;
    // Start is called before the first frame update
    void Start () {
        textDiplay.GetComponent<Text> ().text = "";
    }

    // Update is called once per frame
    void Update () {
        if (TimerScript.finishGame == true) {
            textDiplay.GetComponent<Text> ().text = "You have scored " + ShootScript.points + " Point(s)! Congratulations!";
        }
    }
}