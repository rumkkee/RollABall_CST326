using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int _points;

    public delegate void CollectibleEvent(int points);
    public static event CollectibleEvent OnPickup;

    private void OnTriggerEnter(Collider collider)
    {
        PlayerController player = collider.gameObject.GetComponent<PlayerController>();
        if(player != null)
        {
            OnPickup(_points);
            Destroy(this.gameObject);
        }
    }
}
