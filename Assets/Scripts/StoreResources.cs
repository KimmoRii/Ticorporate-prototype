using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static ResourceManager;

public class StoreResources : MonoBehaviour
{
    public void PutResourcesToStorage()
    {
        resourceManager.totalResources += resourceManager.gatheredResources;
        resourceManager.gatheredResources = 0;
    }
}
