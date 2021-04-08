namespace Abilities_Scripts.Decorator
{
    public interface IAbility
    {
        public void SetAbility();

        public void RemoveAbility();

        public AbilityEnumsManager.AbilityNames GetAbilityType();
    }
}
