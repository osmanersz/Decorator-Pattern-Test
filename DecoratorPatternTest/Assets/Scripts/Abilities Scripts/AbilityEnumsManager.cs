using Abilities_Scripts.Decorator;
using Abilities_Scripts.Decorator.Ability;
using UnityEngine;

namespace Abilities_Scripts
{
    public class AbilityEnumsManager : MonoBehaviour
    {
        public enum AbilityNames
        {
            BaseAbility,
            DiagonalShotAbility,
            MultiShotAbility,
            AttackSpeedBoostAbility,
            FasterBulletsAbility,
            ShooterCloneAbility
        }

        public enum ShotAngle
        {
            Forward,
            LeftRight45Angle
        }

        public enum ShotType
        {
            Single = 1,
            Double = 2,
            Triple = 3
        }
        public enum ShotRateSpeed
        {
            Standart = 2,
            FiftyPercentFaster = 1
        }

        public enum BulletSpeed
        {
            Standart = 1,
            X2SpeedUp = 2
        }


        public static IAbility GetAbilityInterface(AbilityNames abilityName)
        {
            switch (abilityName)
            {
                case AbilityNames.DiagonalShotAbility:
                    return new DiagonalShotAbility();
                case AbilityNames.FasterBulletsAbility:
                    return new FasterBulletsAbility();
                case AbilityNames.MultiShotAbility:
                    return new MultiShotAbility();
                case AbilityNames.ShooterCloneAbility:
                    return new ShooterCloneAbility();
                case AbilityNames.AttackSpeedBoostAbility:
                    return new AttackSpeedBoostAbility();
                default:
                    return new BaseAbilities();
            }
        }
    }
}
