using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public static event UnityAction OnDeadly;

    private float m_Health = 100f;
    private float currentHealth;
    private AudioSource deadVoice;
    public VoiceList list;
    //private float m_DamageFall = 30f;

    private void Start()
    {
        deadVoice = GetComponent<AudioSource>();
        currentHealth = m_Health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            deadVoice.PlayOneShot(list.Robot_Dead);
            OnDeadly?.Invoke();
        }
    }

    //private void FallDamage(Vector3 vel)
    //{
    //    if (Mathf.Abs(vel.y) < 3f) return;
    //    TakeDamage(Mathf.Abs(vel.y) * m_DamageFall);
    //}
}
