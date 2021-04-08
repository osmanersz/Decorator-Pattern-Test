namespace Abilities_Scripts.Decorator.Ability
{
    public class DiagonalShotAbility : AbilityDecorator ,IAbility
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
            return AbilityEnumsManager.AbilityNames.DiagonalShotAbility;
        }

        private void Abilities()
        {
            SetShootAngle(AbilityEnumsManager.ShotAngle.LeftRight45Angle);
        }
    }
}
