using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterOfMass : MonoBehaviour
{
    [SerializeField] private Vector3 m_CenterOfMass;
    [SerializeField] private float m_Radius;
    private Rigidbody m_RB;

    void Start()
    {
        m_RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_RB.centerOfMass = m_CenterOfMass;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawSphere(m_RB.worldCenterOfMass, m_Radius);
    }
}
