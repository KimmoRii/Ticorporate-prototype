using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    public PlayerHealth playerHealth;
    [SerializeField] int damageValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player was hit by spikes!");
            playerHealth.Damage(damageValue);
        }
    }
}
