using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardRotation : MonoBehaviour
{
    public float rotateSpeed = 30;

    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
    }
}
