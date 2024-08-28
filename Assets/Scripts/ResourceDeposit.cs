using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDeposit : MonoBehaviour
{
    [SerializeField] int resourceValue;
    [SerializeField] int durability;
    public ResourceManager resourceManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickaxe"))
        {
            durability -= 1;
            Debug.Log("Resource deposit is breaking.");

            if (durability <= 0)
            {
                resourceManager.gatheredResources += resourceValue;
                Destroy(gameObject);
            }
        }
    }
}
