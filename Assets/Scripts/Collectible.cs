using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public delegate void CollectibleEvent(int points);
    public static event CollectibleEvent OnPickup;

    [SerializeField] private int points;

    private void OnTriggerEnter(Collider collider)
    {
        PlayerController player = collider.GetComponent<PlayerController>();
        if(player != null)
        {
            // TODO: Have the player's score update using this event.
            OnPickup(points);
            Destroy(this.gameObject);
        }
    }
}
