using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Dieses Skript wird für die Konfiguration des Levels verwendet
public class LevelChangeScript : MonoBehaviour {

    public void SetLevel (float level) {
        VirusBehaviourScript.speed = level;
    }
}