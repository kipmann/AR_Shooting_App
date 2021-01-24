using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dieses Skript dient zur Anzeige der gesammelten Punkten
public class PointsCounterScript : MonoBehaviour {

    public GameObject textDiplay;

    // Nach dem Neustart wird es zurückgesetzt
    void Start () {
        textDiplay.GetComponent<Text> ().text = "0";
    }
    // Es wird Live per Frame aktualisiert
    void Update () {
        textDiplay.GetComponent<Text> ().text = "" + ShootScript.points;
    }
}