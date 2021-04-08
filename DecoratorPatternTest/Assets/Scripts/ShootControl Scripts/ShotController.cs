using System;
using System.Collections;
using Abilities_Scripts;
using UnityEngine;

namespace ShootControl_Scripts
{
    public class ShotController : MonoBehaviour
    {
        public static event Action<AbilityEnumsManager.ShotAngle, AbilityEnumsManager.BulletSpeed>
            ShotEvent;
        private float _currentFireRate = 1f;
        private bool _canShot = true;
        
        public void OnShotEvent(AbilityEnumsManager.ShotAngle shotAngle,
            AbilityEnumsManager.BulletSpeed bulletSpeed)
        {
            ShotEvent?.Invoke(shotAngle, bulletSpeed);
        }

        private void OnEnable()
        {
            AbilityEvents.FireRateSpeedUpdate += FireRateSpeedUpdate;
        }
        private void OnDisable()
        {
            AbilityEvents.FireRateSpeedUpdate -= FireRateSpeedUpdate;
        }

        private void FireRateSpeedUpdate(float fireRateSpeed)
        {
            _currentFireRate = fireRateSpeed;
        }

        private void Update()
        {
            if (_canShot)
            {
                _currentFireRate -= Time.deltaTime;
                if (_currentFireRate < 0) Shot();
            }
        }

        private void Shot()
        {
            _canShot = false;
            StartCoroutine(ShotIe());
        }

        private IEnumerator ShotIe()
        {
            _currentFireRate = (int) AbilityEvents.ShotRateSpeed;
            for (int i = 0; i < (int)AbilityEvents.ShotType; i++)
            {
                foreach (var shootAngle in AbilityEvents.ShotAngles)
                {
                    OnShotEvent(shootAngle, AbilityEvents.BulletSpeed);
                }

                yield return new WaitForSeconds(_currentFireRate / 100 * 2);
            }
            
            _canShot = true;
        }


    }
}
