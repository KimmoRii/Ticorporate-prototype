using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager resourceManager;
    public int gatheredResources;
    public int totalResources;

    private void Awake()
    {
        if (resourceManager == null)
        {
            resourceManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (resourceManager != this)
        {
            Destroy(gameObject);
        }
    }
}
