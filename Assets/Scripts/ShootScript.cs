using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dieser Code hat eine Shooting-Logik
// Die Logik dieses Codes stammt teilweise von diesem Tutorial https://www.youtube.com/watch?v=RzmBnllRnh8
public class ShootScript : MonoBehaviour {

    // Deklarieren bzw. Initialisieren Variablen
    public GameObject arCamera;
    public GameObject smoke;
    public static int points = 0;

    // wird fuer die richtige Anzeige der Punkten benoetigt
    void Start () {
        points = 0;
    }

    // Shooting Logik
    public void Shoot () {

        RaycastHit hit;

        if (Physics.Raycast (arCamera.transform.position, arCamera.transform.forward, out hit)) {

            if (hit.transform.name == "balloon1" || hit.transform.name == "balloon2" || hit.transform.name == "balloon3" ||
                hit.transform.name == "balloon4" || hit.transform.name == "balloon5" || hit.transform.name == "balloon6" ||
                hit.transform.name == "balloon7" || hit.transform.name == "balloon8" || hit.transform.name == "balloon9"
            ) {
                //Destroyen unseres Luftballons
                Destroy (hit.transform.gameObject);

                //wenn kein gelber Luftballon getroffen ist +1
                if (hit.transform.name == "balloon1" || hit.transform.name == "balloon2" ||
                    hit.transform.name == "balloon4" || hit.transform.name == "balloon5" ||
                    hit.transform.name == "balloon7" || hit.transform.name == "balloon8") {
                    points++;
                }

                //wenn ein gelber Luftballon getroffen ist -2
                if (hit.transform.name == "balloon3" || hit.transform.name == "balloon6" || hit.transform.name == "balloon9") {
                    points = points - 2;
                }
                Instantiate (smoke, hit.point, Quaternion.LookRotation (hit.normal));
            }
        }
    }

}