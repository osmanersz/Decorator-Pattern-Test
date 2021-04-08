namespace Abilities_Scripts.Decorator.Ability
{
    public class MultiShotAbility : AbilityDecorator ,IAbility
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
            return AbilityEnumsManager.AbilityNames.MultiShotAbility;
        }

        private void Abilities()
        {
            SetShotType(AbilityEnumsManager.ShotType.Double);
        }
    }
}
