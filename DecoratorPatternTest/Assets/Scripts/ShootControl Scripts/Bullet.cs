using Lean.Pool.Scripts;
using UnityEngine;

namespace ShootControl_Scripts
{
    public class Bullet : MonoBehaviour
    {
        private const float BaseBulletSpeed = 50;
        private Rigidbody _myRigidbody;

        private void Awake()
        {
            _myRigidbody = GetComponent<Rigidbody>();
        }

        public void SetDirection(Vector3 direction, float bulletSpeed)
        {
            var myTransform = transform;
            myTransform.eulerAngles = direction;
            _myRigidbody.AddForce(myTransform.forward * (BaseBulletSpeed * bulletSpeed), ForceMode.Impulse);
            LeanPool.Despawn(gameObject, 10f);
        }
    }
}
