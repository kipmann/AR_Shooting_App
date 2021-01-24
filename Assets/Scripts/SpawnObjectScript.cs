using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Der Code wird derzeit nicht benutzt, weil wir mit Vuforia die GameObjects platzieren
// Wenn man Vuforia deaktivieren möchte, kann man dieses Skript benutzten, um die Objekte zu platzieren
// Stammt teilweise von https://www.youtube.com/watch?v=RzmBnllRnh8
public class SpawnObjectScript : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject[] viruses;

    // Start is called before the first frame update
    void Start () {
        StartCoroutine (StartSpawning ());
    }

    IEnumerator StartSpawning () {
        yield return new WaitForSeconds (4);

        for (int i = 0; i < 3; i++) {
            Instantiate (viruses[i], spawnPoints[i].position, Quaternion.identity);

        }

        StartCoroutine (StartSpawning ());

    }

}