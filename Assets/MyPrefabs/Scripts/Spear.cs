using UnityEngine;

public class Spear : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float m_Damage;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * m_Speed, ForceMode.Acceleration);

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Health>() == null) return;

        collision.gameObject.GetComponent<Health>().TakeDamage(m_Damage);
        rb.isKinematic = true;
    }
}
