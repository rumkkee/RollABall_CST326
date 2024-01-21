using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAmount;

    private void FixedUpdate()
    {
        transform.Rotate(rotationAmount * Time.deltaTime);
    }
}
