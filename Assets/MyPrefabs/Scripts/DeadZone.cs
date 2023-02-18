using UnityEngine;

namespace StarterAssets
{
    public class DeadZone : MonoBehaviour
    {
        private float m_damage = 1000f;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                other.GetComponent<Health>().TakeDamage(m_damage);
            }
        }
    }
}