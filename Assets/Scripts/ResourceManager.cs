using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceManager : MonoBehaviour
{
    public int gatheredResources;
    [SerializeField] TMP_Text gatheredResourcesText;

    // Update is called once per frame
    void Update()
    {
        gatheredResourcesText.text = "Resources: " + gatheredResources;
    }
}
