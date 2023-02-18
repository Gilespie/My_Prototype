using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFloat : MonoBehaviour
{
    [SerializeField] private float m_Force;
    
    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(Vector3.up * m_Force);
        other.attachedRigidbody.angularDrag = 1f;
        other.attachedRigidbody.drag = 1f;
    }
}
