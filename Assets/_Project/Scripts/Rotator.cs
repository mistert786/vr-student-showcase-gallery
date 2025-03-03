using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField, Tooltip("Angular velocity in degrees per second")]
    private Vector3 velocity;

    private void FixedUpdate()
    {
        transform.Rotate(velocity * Time.fixedDeltaTime);
    }
}
