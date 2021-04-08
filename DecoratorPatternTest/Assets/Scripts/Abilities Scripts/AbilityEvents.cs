using System;
using System.Collections.Generic;
using Abilities_Scripts.Decorator;
using Abilities_Scripts.Decorator.Ability;
using UnityEngine;

namespace Abilities_Scripts
{
   public class AbilityEvents : MonoBehaviour
   {
      public static readonly List<IAbility> Abilities = new List<IAbility>();
      public static readonly List<AbilityEnumsManager.ShotAngle> ShotAngles =
         new List<AbilityEnumsManager.ShotAngle>();
      public static AbilityEnumsManager.BulletSpeed BulletSpeed;
      public static AbilityEnumsManager.ShotType ShotType;
      public static AbilityEnumsManager.ShotRateSpeed ShotRateSpeed;

      public static event Action<IAbility> AbilityUpdate;
      public static event Action<float> FireRateSpeedUpdate;

      private void Awake()
      {
         Abilities.Clear();
         ShotAngles.Clear();
         CacheClear();
      }
      public void CacheClear()
      {
         BaseAbilities baseAbilities = new BaseAbilities();
         BulletSpeed = AbilityEnumsManager.BulletSpeed.Standart;
         ShotType = AbilityEnumsManager.ShotType.Single;
         ShotRateSpeed = AbilityEnumsManager.ShotRateSpeed.Standart;
         baseAbilities.SetAbility();
      }
      
      public static void OnAbilityUpdate(IAbility ability)
      {
         AbilityUpdate?.Invoke(ability);
      }

      public static void OnFireRateSpeedUpdate(float fireRateSpeed)
      {
         FireRateSpeedUpdate?.Invoke(fireRateSpeed);
      }
   }
}
