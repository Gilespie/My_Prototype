using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFall : MonoBehaviour
{
    [SerializeField] private Trigger m_Trigger;
    [SerializeField] private Rigidbody[] m_RBs;

    void Start()
    {
        m_Trigger.OnEvent += ActivateEvent;
    }

    private void OnDisable()
    {
        m_Trigger.OnEvent -= ActivateEvent;
    }

    private void ActivateEvent()
    {
        for(int i = 0; i < m_RBs.Length; i++)
        {
            m_RBs[i].isKinematic = false;
            Destroy(m_RBs[i].gameObject, 7f);
        }
    }
}
