namespace Abilities_Scripts.Decorator.Ability
{
    public class ShooterCloneAbility : AbilityDecorator ,IAbility
    {
        public void SetAbility()
        {
            base.SetAbility(this);
        }

        public void RemoveAbility()
        {
            base.RemoveAbility(this);
        }

        public AbilityEnumsManager.AbilityNames GetAbilityType()
        {
            return AbilityEnumsManager.AbilityNames.ShooterCloneAbility;
        }
    }
}
