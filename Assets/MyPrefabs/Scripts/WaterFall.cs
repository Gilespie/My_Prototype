using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFall : MonoBehaviour
{
    //[SerializeField] private Trigger m_Trigger;
    private AudioSource m_Audio;
    private ParticleSystem m_WaterFall;

    private void Start()
    {
        OnInteractive.OnExplosive += OnReaction;
        //m_Trigger.OnEvent += OnReaction;
        m_WaterFall = GetComponentInChildren<ParticleSystem>();
        m_WaterFall.Pause();
        m_Audio = GetComponentInChildren<AudioSource>();
    }

    private void OnDisable()
    {
        OnInteractive.OnExplosive -= OnReaction;
        //m_Trigger.OnEvent -= OnReaction;
    }

    private void OnReaction()
    {
        m_WaterFall.Play();
        m_Audio.Play();
    }
}
