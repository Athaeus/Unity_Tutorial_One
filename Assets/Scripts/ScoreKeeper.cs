using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Obstacle") {
            hits++;
            Debug.Log("Uh oh! You've bumped into an obstacle this many times: " + hits);
        }
    }
}
