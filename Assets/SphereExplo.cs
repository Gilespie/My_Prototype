using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereExplo : MonoBehaviour
{
    [SerializeField] private float m_Power;
    [SerializeField] private float m_Radius;

    private Rigidbody m_RB;
    private Health person;

    private void Start()
    {
        OnInteractive.OnExplosive += Explo;
    }

    private void OnDestroy()
    {
        OnInteractive.OnExplosive -= Explo;
    }

    private void Explo()
    {
        Collider[] rb = Physics.OverlapSphere(transform.position, m_Radius);

        for (int i = 0; i < rb.Length; i++)
        {
            m_RB = rb[i].attachedRigidbody;
            person = rb[i].GetComponentInParent<Health>();

            if (m_RB)
            {
                if(person)
                {
                    person.TakeDamage(3000);
                }

                m_RB.isKinematic = false;
                m_RB.AddExplosionForce(m_Power, transform.position, m_Radius, 3f);
            }
        }

        Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, m_Radius);
    }
}
