using System.Collections.Generic;
using Abilities_Scripts;
using Lean.Pool.Scripts;
using UnityEngine;

namespace ShootControl_Scripts
{
    public sealed class Shooter : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab = null;

        private void OnEnable()
        {
            ShotController.ShotEvent += OnShotEvent;
        }

        private void OnDisable()
        {
            ShotController.ShotEvent -= OnShotEvent;
        }

        private void OnShotEvent(AbilityEnumsManager.ShotAngle shotAngle,
            AbilityEnumsManager.BulletSpeed bulletSpeed)
        {
            List<Vector3> directions = new List<Vector3>();
            switch (shotAngle)
            {
                case AbilityEnumsManager.ShotAngle.Forward:
                    directions.Add(Vector3.zero);
                    break;
                case AbilityEnumsManager.ShotAngle.LeftRight45Angle:
                    directions.Add(new Vector3(0, -45, 0));
                    directions.Add(new Vector3(0, 45, 0));
                    break;
            }

            foreach (var direction in directions)
            {
                BulletSpawner(direction, (float) bulletSpeed);
            }

        }

        private void BulletSpawner(Vector3 extraDirection, float bulletSpeed)
        {
            var myTransform = transform;
            GameObject bullet = LeanPool.Spawn(bulletPrefab, myTransform.position, Quaternion.identity);
            Vector3 direction = transform.eulerAngles + extraDirection;
            bullet.GetComponent<Bullet>().SetDirection(direction, bulletSpeed);
        }
    }
}
