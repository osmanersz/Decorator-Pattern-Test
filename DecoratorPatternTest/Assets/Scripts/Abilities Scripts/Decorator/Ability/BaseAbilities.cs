namespace Abilities_Scripts.Decorator.Ability
{
    public class BaseAbilities : AbilityDecorator ,IAbility
    {
        public void SetAbility()
        {
            Abilities();
            base.SetAbility(this);
        }

        public void RemoveAbility()
        {
        }

        public AbilityEnumsManager.AbilityNames GetAbilityType()
        {
            return AbilityEnumsManager.AbilityNames.BaseAbility;
        }

        private void Abilities()
        {
            SetShotType(AbilityEnumsManager.ShotType.Single);
            SetShootAngle(AbilityEnumsManager.ShotAngle.Forward);
            SetShotRateSpeed(AbilityEnumsManager.ShotRateSpeed.Standart);
        }
    }
}
