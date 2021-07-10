using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody ridgid;
    [SerializeField] float timeToDrop = 6.0f;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        ridgid = GetComponent<Rigidbody>();

        render.enabled = false;   // Caching odniesien (np. do komponentow) pozwala w tym przypadku nie uzywac
        ridgid.useGravity = false;   // wielokrotnie GetComponent<>(), a po prostu nazwy zmiennej.
    }

    void Update()
    {
        if(Time.time > timeToDrop) {    // Time.time pozwala na dostep do czasu, ktory uplynal od runtime'u.
            render.enabled = true;
            ridgid.useGravity = true;
        }   
    }
}