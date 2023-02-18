using UnityEngine;

public class ActivateParticleCollison : MonoBehaviour
{
    [SerializeField] private float m_ActivationForce = 20f;
    [SerializeField] private GameObject m_ParticleActivate;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > m_ActivationForce)
        {
            m_ParticleActivate.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.relativeVelocity.sqrMagnitude > m_ActivationForce)
        {
            m_ParticleActivate.SetActive(true);
        }
    }

}
