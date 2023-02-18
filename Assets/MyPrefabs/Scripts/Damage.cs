using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float m_Damage;

    [SerializeField] private Health m_Person;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        m_Person.TakeDamage(m_Damage);
    }

    void Update()
    {
        m_Damage = rb.mass * rb.velocity.magnitude;
    }
}