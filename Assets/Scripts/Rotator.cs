using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationAmount;

    private void FixedUpdate()
    {
        transform.Rotate(_rotationAmount * Time.deltaTime);
    }
}
