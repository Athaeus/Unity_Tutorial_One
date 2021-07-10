using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpinner : MonoBehaviour
{
    [SerializeField] float rotX, rotY, rotZ;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotX, rotY, rotZ);
    }
}
