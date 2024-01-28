using MoreMountains.TopDownEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalDetection : MonoBehaviour
{
    public BoxCollider2D activationZone;
    public TimedSpawner spawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 10)
            spawn.CanSpawn = true;
    }
}
