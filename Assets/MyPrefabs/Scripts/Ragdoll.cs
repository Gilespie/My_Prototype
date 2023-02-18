using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] private Collider[] m_Colliders;
    [SerializeField] private Rigidbody[] m_RBs;
    private CharacterController m_Controller;
    private ThirdPersonController m_PersonController;
    private Animator m_Animator;
    private PlayerInput m_Input;

    void Start()
    {
        Health.OnDeadly += DeathRagdoll;

        m_Controller = GetComponent<CharacterController>();
        m_Animator = GetComponent<Animator>();
        m_PersonController = GetComponent<ThirdPersonController>();
        m_Input = GetComponent<PlayerInput>();

        for (int i = 0; i < m_Colliders.Length; i++)
        {
            m_Colliders[i].enabled = false;

            for (int j = 0; j < m_RBs.Length; j++)
            {
                m_RBs[j].useGravity = false;
            }
        }
        
    }

    private void OnDisable()
    {
        Health.OnDeadly -= DeathRagdoll;
    }

    private void DeathRagdoll()
    {
        m_Controller.enabled = false;
        m_Animator.enabled = false;
        m_PersonController.enabled = false;
        m_Input.enabled = false;

        for (int i = 0; i < m_Colliders.Length; i++)
        {
            m_Colliders[i].enabled = true;

            for (int j = 0; j < m_RBs.Length; j++)
            {
                m_RBs[j].useGravity = true;
            }
        }
    }
}
