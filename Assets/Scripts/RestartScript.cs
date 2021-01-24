using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Dieses Skript dient zum Neustart der Szene bzw. des Spiels
public class RestartScript : MonoBehaviour {

    public void RestartGame () {
        SceneManager.LoadScene ("Shooting-App");
    }

}