using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - targetObject.transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = targetObject.transform.position + _offset;
    }
}
