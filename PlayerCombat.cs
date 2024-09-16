using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{ 
public Animator animator;

// Update is called once per frame
void Update()
{
    // Check if the attack button is pressed
    if (Input.GetButtonDown("Fire1")) // Use "Fire1" for button input or replace with a specific KeyCode if necessary
    {
        Attack();
    }
}

void Attack()
{
    animator.SetTrigger("Attack");

    // Detect enemies in range of attack
    // Damage Enemies
}
}