using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureSystem : MonoBehaviour
{
    [SerializeField] float maxTemperature;
    public float currentTemperature;
    [SerializeField] int temperatureDecreaseMultiplier;

    public TemperatureBar temperatureBar;

    // Start is called before the first frame update
    void Start()
    {
        currentTemperature = maxTemperature;
    }

    // Update is called once per frame
    void Update()
    {
        currentTemperature -= Time.deltaTime * temperatureDecreaseMultiplier;
        temperatureBar.SetTemperature(currentTemperature);

    }
}
