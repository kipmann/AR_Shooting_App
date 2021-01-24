using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dieses Skript dient zur Bewegung der Luftbaloons (0.2 ist default, entspricht LOW Level)
// public static float speed kann mit den Level Buttons parametrisiert werden und live im Spiel aktualisiert werden
public class VirusBehaviourScript : MonoBehaviour {
  public static float speed = 0.2f;
  // Start is called before the first frame update
  void Start () {

  }

  // Update is called once per frame
  void Update () {
    transform.Translate (Vector3.up * Time.deltaTime * speed);

  }
}