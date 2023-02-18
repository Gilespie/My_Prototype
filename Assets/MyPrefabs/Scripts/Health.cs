using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public static event UnityAction OnDeadly;

    private float m_Health = 100f;
    private float currentHealth;
    //private float m_DamageFall = 30f;

    private void Start()
    {
        currentHealth = m_Health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            OnDeadly?.Invoke();
        }
    }

    //private void FallDamage(Vector3 vel)
    //{
    //    if (Mathf.Abs(vel.y) < 3f) return;
    //    TakeDamage(Mathf.Abs(vel.y) * m_DamageFall);
    //}
}
