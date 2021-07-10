using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player") {  // Tagi w Unity pozwalaja organizowac obiekty i np wykonywac operacje TYLKO na obiektach o danym tagu.
            GetComponent<MeshRenderer>().material.color = Color.yellow;
            gameObject.tag = "Hit";
        }
    }
}
