using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public int meleeDamage;
    [SerializeField] private float meleeCooldown;
    private float timeUntilMelee;
    public Collider2D weaponCollider;

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
                animator.SetTrigger("Attack");
                timeUntilMelee = meleeCooldown;
            }
        }
        else
        {
            timeUntilMelee -= Time.deltaTime;
        }
    }

    private void StrikeBegan()
    {
        weaponCollider.enabled = true;
    }

    private void StrikeEnded()
    {
        weaponCollider.enabled = false;
    }
}
