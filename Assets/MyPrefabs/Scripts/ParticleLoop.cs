using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLoop : MonoBehaviour
{
    private ParticleSystem m_Particle;

    void Start()
    {
        m_Particle = GetComponent<ParticleSystem>();
    }
    
    public void TurnOffLoop()
    {
        var main = m_Particle.main;
        main.loop = false;
    }
}
