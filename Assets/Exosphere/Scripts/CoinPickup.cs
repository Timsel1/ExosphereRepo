using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : PickableItem
{
    [Tooltip("the amount of coins to give the player when collected")]
    public float CoinsToGive = 1f;

    /// <summary>
    /// What happens when the object gets picked
    /// </summary>
    protected override void Pick(GameObject picker)
    {
        Health characterHealth = _pickingCollider.GetComponent<Health>();
        // else, we give health to the player
        characterHealth.GetHealth(CoinsToGive, gameObject);
    }
}
