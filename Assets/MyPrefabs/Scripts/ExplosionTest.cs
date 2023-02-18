using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{
    [SerializeField] private float m_Power;
    [SerializeField] private float m_Radius;
    [SerializeField] private bool IsExplo;
    private Rigidbody m_RB;

    void Update()
    {
        if (IsExplo)
            Explo();
    }

    private void Explo()
    {
        Collider[] rb = Physics.OverlapSphere(transform.position, m_Radius);

        for (int i = 0; i < rb.Length; i++)
        {
            m_RB = rb[i].attachedRigidbody;

            if (m_RB)
                m_RB.AddExplosionForce(m_Power, transform.position, m_Radius);
        }

        Destroy(gameObject);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, m_Radius);
    }
}
