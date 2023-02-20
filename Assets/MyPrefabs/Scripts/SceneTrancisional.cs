using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneTrancisional : MonoBehaviour
{
    public static event UnityAction OnFade;

    [SerializeField] private Animator m_Animator;
    [SerializeField] private Trigger m_TriggerEnd;
    [SerializeField] private bool IsActive;

    void Start()
    {
        Health.OnDeadly += FadeIn;
        m_TriggerEnd.OnEvent += FadeEnd;

        if(IsActive)
        {
            FadeOut();
        }    
    }

    private void OnDisable()
    {
        Health.OnDeadly -= FadeIn;
        m_TriggerEnd.OnEvent -= FadeEnd;
    }

    private void FadeIn()
    {
        m_Animator.SetBool("FadeIn", true);
        OnFade?.Invoke();
    }

    private void FadeOut()
    {
        m_Animator.SetBool("FadeIn", false);
    }

    IEnumerator Transition()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
    }

    private void FadeEnd()
    {
        m_Animator.SetBool("FadeIn", true);
        StartCoroutine(Transition());
    }
}
