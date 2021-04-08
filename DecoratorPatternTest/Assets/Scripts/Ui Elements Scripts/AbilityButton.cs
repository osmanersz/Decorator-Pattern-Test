using Abilities_Scripts;
using Abilities_Scripts.Decorator;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Ui_Elements_Scripts
{
    public class AbilityButton : MonoBehaviour
    {
        private IAbility _ability;
        [FormerlySerializedAs("ability")] [SerializeField] private AbilityEnumsManager.AbilityNames abilityName = AbilityEnumsManager.AbilityNames.BaseAbility;
        private Image _buttonImage = null;
        private bool _isActive;

        private void Awake()
        {
            _buttonImage = gameObject.GetComponent<Image>();
            _ability = AbilityEnumsManager.GetAbilityInterface(abilityName);
        }

        private void OnEnable()
        {
            AbilityEvents.AbilityUpdate += AbilityCheck;
        }

        private void OnDisable()
        {
            AbilityEvents.AbilityUpdate -= AbilityCheck;
        }

        private void AbilityCheck(IAbility newAbility)
        {
            if (abilityName == newAbility.GetAbilityType())
            {
                if (_isActive)
                {
                    _isActive = false;
                    _buttonImage.color = Color.white;
                }
                else
                {
                    _isActive = true;
                    _buttonImage.color = Color.green;
                }
            }
        }

        public void ActivateButton()
        {
            if (_isActive)
            {
                _ability.RemoveAbility();
            }
            else
            {
                _ability.SetAbility();
            }
        }
    }
}
