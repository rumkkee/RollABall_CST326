using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _targetObject.transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = _targetObject.transform.position + _offset;
    }
}
