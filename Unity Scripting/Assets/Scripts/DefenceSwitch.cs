using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DefenceSwitch : MonoBehaviour
{
 public enum Defences
 {
  Sheild,
  Potions,
  ExtraHealth,
  Buffs,
  Supershield
 }

 public Defences currentDefences;

 public void RunCurrentDefence()
 {
  switch (currentDefences)
  {
   case Defences.Sheild:
    break;
   case Defences.Potions:
    break;
   case Defences.ExtraHealth:
    break;
   case Defences.Buffs:
    break;
   case Defences.Supershield:
    break;
   default:
    throw new ArgumentOutOfRangeException();
  }
 }
}
