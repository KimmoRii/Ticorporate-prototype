using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using static ResourceManager;

public class ResourceUI : MonoBehaviour
{
    [SerializeField] TMP_Text gatheredResourcesText;
    [SerializeField] TMP_Text totalResourcesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gatheredResourcesText.text = "Resources: " + resourceManager.gatheredResources;
        totalResourcesText.text = "Total resources: " + resourceManager.totalResources;
    }
}
