using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public int meleeDamage;
    [SerializeField] int meleeStaminaCost;
    [SerializeField] private float meleeCooldown;
    private float timeUntilMelee;
    public Collider2D weaponCollider;

    public PlayerStamina playerStamina;

    // Start is called before the first frame update
    void Start()
    {
        weaponCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUntilMelee <= 0f)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Attack();
            }
        }
        else
        {
            timeUntilMelee -= Time.deltaTime;
        }
    }

    private void Attack()
    {
        if (playerStamina.currentStamina < meleeStaminaCost)
        {
            return;
        }

        animator.SetTrigger("Attack");
        timeUntilMelee = meleeCooldown;
        playerStamina.LoseStamina(meleeStaminaCost);
    }

    private void StrikeBeganEvent()
    {
        weaponCollider.enabled = true;
    }

    private void StrikeEndedEvent()
    {
        weaponCollider.enabled = false;
    }
}
