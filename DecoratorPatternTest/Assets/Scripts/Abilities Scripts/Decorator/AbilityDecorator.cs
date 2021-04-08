namespace Abilities_Scripts.Decorator
{
    public abstract class AbilityDecorator
    {
        public void SetAbility(IAbility iAbility)
        {
            AbilityEvents.Abilities.Add(iAbility);
            AbilityEvents.OnAbilityUpdate(iAbility);
            
            if (AbilityEvents.Abilities.Count > 4)
            {
                AbilityEvents.Abilities[1].RemoveAbility();
            }
        }

        public void RemoveAbility(IAbility iAbility)
        {
            AbilityEvents.Abilities.Remove(iAbility);
            AbilityEvents.OnAbilityUpdate(iAbility);
        }

        public void SetShootAngle(AbilityEnumsManager.ShotAngle shotAngle)
        {
            if (!AbilityEvents.ShotAngles.Contains(shotAngle))
                AbilityEvents.ShotAngles.Add(shotAngle);
            else
                AbilityEvents.ShotAngles.Remove(shotAngle);
        }

        public void SetShotType(AbilityEnumsManager.ShotType type)
        {
            if (AbilityEvents.ShotType != type)
            {
                AbilityEvents.ShotType = type;
            }
            else
            {
                AbilityEvents.ShotType = AbilityEnumsManager.ShotType.Single;
            }
        }

        public void SetShotRateSpeed(AbilityEnumsManager.ShotRateSpeed rateSpeed)
        {
            if (AbilityEvents.ShotRateSpeed != rateSpeed)
            {
                AbilityEvents.ShotRateSpeed = rateSpeed;
            }
            else
                AbilityEvents.ShotRateSpeed = AbilityEnumsManager.ShotRateSpeed.Standart;

            AbilityEvents.OnFireRateSpeedUpdate((float) AbilityEvents.ShotRateSpeed);
        }

        public void SetBulletSpeed(AbilityEnumsManager.BulletSpeed bulletSpeed)
        {
            if (AbilityEvents.BulletSpeed != bulletSpeed)
            {
                AbilityEvents.BulletSpeed = bulletSpeed;
            }
            else
                AbilityEvents.BulletSpeed = AbilityEnumsManager.BulletSpeed.Standart;
        }
    }
}
