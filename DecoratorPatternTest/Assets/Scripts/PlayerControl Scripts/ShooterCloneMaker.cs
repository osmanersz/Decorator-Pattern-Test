using Abilities_Scripts;
using Abilities_Scripts.Decorator;
using Lean.Pool.Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

namespace PlayerControl_Scripts
{
    public class ShooterCloneMaker : MonoBehaviour
    {
        [SerializeField] private GameObject shooterPrefab = null;
        private GameObject _currentShooterClone;

        private void OnEnable()
        {
            AbilityEvents.AbilityUpdate += AbilityCheck;
        }

        private void OnDisable()
        {
            AbilityEvents.AbilityUpdate -= AbilityCheck;
        }

        private void AbilityCheck(IAbility ability)
        {
            if (ability.GetAbilityType() == AbilityEnumsManager.AbilityNames.ShooterCloneAbility)
            {
                if (_currentShooterClone)
                {
                    Destroy(_currentShooterClone);
                }
                else
                {
                    CloneSpawner();
                }
            }
        }

        private void CloneSpawner()
        {
            _currentShooterClone = LeanPool.Spawn(shooterPrefab, RandomCircle(transform.position, 5f),
                Quaternion.identity);
            var transformRotation = _currentShooterClone.transform.rotation;
            transformRotation.y = Random.rotation.y;
            _currentShooterClone.transform.rotation = transformRotation;
        }

        private Vector3 RandomCircle(Vector3 center, float radius)
        {
            float ang = Random.value * 360;
            Vector3 pos;
            pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
            pos.y = center.y + 1.5f;
            pos.z = center.z;
            return pos;
        }
    }
}
