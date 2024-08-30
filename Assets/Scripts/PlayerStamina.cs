using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    public static PlayerStamina playerStamina;

    [SerializeField] float maxStamina;
    public float currentStamina;
    [SerializeField] int staminaRegenMultiplier;

    public StaminaBar staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.SetStamina(maxStamina);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentStamina < maxStamina)
        {
            currentStamina += Time.deltaTime * staminaRegenMultiplier;
            staminaBar.SetStamina(currentStamina);
        }
        else
        {
            currentStamina = maxStamina;
        }
    }

    public void LoseStamina(int stamina)
    {
        currentStamina -= stamina;

        if (currentStamina < 0)
        {
            currentStamina = 0;
        }

        staminaBar.SetStamina(currentStamina);
    }
}
