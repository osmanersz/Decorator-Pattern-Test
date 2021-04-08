namespace Abilities_Scripts.Decorator.Ability
{
    public class FasterBulletsAbility : AbilityDecorator ,IAbility
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
            return AbilityEnumsManager.AbilityNames.FasterBulletsAbility;
        }

        private void Abilities()
        {
            SetBulletSpeed(AbilityEnumsManager.BulletSpeed.X2SpeedUp);
        }
    }
}
