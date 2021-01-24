using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Der Timer wurde teilweise implementiert, wie in diesem Tutorial https://www.youtube.com/watch?v=Qhm_t46kuM4
public class TimerScript : MonoBehaviour {
    public GameObject textDiplay;
    public int secondsLeft = 30;
    public bool takingAway = false;
    public static bool finishGame = false;

    void Start () {
        textDiplay.GetComponent<Text> ().text = "00:" + secondsLeft;
        finishGame = false;
    }

    void Update () {
        if (takingAway == false && secondsLeft > 0) {
            StartCoroutine (TimerTake ());
        }
        if (secondsLeft == 0) {
            finishGame = true;
        }
    }
    IEnumerator TimerTake () {
        takingAway = true;
        yield return new WaitForSeconds (1);
        secondsLeft -= 1;

        if (secondsLeft < 10) {
            textDiplay.GetComponent<Text> ().text = "00:0" + secondsLeft;
        } else {
            textDiplay.GetComponent<Text> ().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }

}