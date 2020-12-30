using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.VersionControl;
using UnityEngine;


public class ControllerReview : MonoBehaviour
{
  public int MaxHealth = 100;
  public int CurrentHealth;
  public Health healthBar;

  private void Start()
  {
    CurrentHealth = MaxHealth;
    healthBar.SetMaxHealth(MaxHealth);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      TakeDamage(20);
    }

    void TakeDamage(int damage)
    {
      CurrentHealth -= damage;
      healthBar.SetHealth(CurrentHealth);
    }
  }
}
