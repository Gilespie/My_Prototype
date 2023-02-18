using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveteDust : MonoBehaviour
{
    [SerializeField] private GameObject[] m_Particles;
    [SerializeField] private Trigger m_Trigger;
    void Start()
    {
        for (int i = 0; i < m_Particles.Length; i++)
        {
            m_Particles[i].SetActive(false);
        }

        m_Trigger.OnEvent += ActivateParticle;
    }

    private void OnDisable()
    {
        m_Trigger.OnEvent -= ActivateParticle;
    }

    private void ActivateParticle()
    {
        for(int i = 0; i < m_Particles.Length; i++)
        {
            m_Particles[i].SetActive(true);
        }
    }
}
