namespace Abilities_Scripts.Decorator.Ability
{
    public class AttackSpeedBoostAbility : AbilityDecorator ,IAbility
    {
        public void SetAbility()
        {
            Abilities();
            base.SetAbility(this);
        }

        public void RemoveAbility()
        {
            Abilities();
            base.RemoveAbility(this);
        }

        public AbilityEnumsManager.AbilityNames GetAbilityType()
        {
            return AbilityEnumsManager.AbilityNames.AttackSpeedBoostAbility;
        }

        private void Abilities()
        {
            SetShotRateSpeed(AbilityEnumsManager.ShotRateSpeed.FiftyPercentFaster);
        }
    }
}
