using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class SlowMotion : MonoBehaviour
{
    [SerializeField] private Trigger m_Trigger;
    [SerializeField] private ThirdPersonController m_Person;
    [SerializeField] private Camera m_MainCamera;
    [SerializeField] private Camera EventCamera;
    [SerializeField] private float m_Sprint;
    [SerializeField] private float m_Timescale;
    [SerializeField] private AudioSource m_HeartSX;
    [SerializeField] private AudioSource m_StoneSX;
    [SerializeField] private Animator m_Anim;
    private float defaultSpeed;
    private float defaulttimescale;
    private float seconds = 3f;
    

    private void Start()
    {
        defaultSpeed = m_Person.SprintSpeed;
        defaulttimescale = Time.timeScale;
        EventCamera.enabled = false;
        m_Trigger.OnEvent += ActivateEvent;
    }

    private void OnDisable()
    {
        m_Trigger.OnEvent -= ActivateEvent;
    }

    private void ActivateEvent()
    {
        StartCoroutine(SlowMo());
    }

    IEnumerator SlowMo()
    {
        m_Anim.SetBool("IsClosed", true);
        EventCamera.enabled = true;
        m_MainCamera.enabled = false;
        m_HeartSX.Play();
        m_StoneSX.Play();
        m_Person.SprintSpeed = m_Sprint;
        Time.timeScale = m_Timescale;
        yield return new WaitForSecondsRealtime(seconds);
        m_Anim.SetBool("IsClosed", false);
        EventCamera.enabled = false;
        m_MainCamera.enabled = true;
        m_HeartSX.enabled = false;
        m_StoneSX.enabled = false;
        m_Person.SprintSpeed = defaultSpeed;
        Time.timeScale = defaulttimescale;
        StopCoroutine(SlowMo());
    }
}
