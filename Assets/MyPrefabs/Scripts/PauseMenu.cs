using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button m_ResumeButton;
    [SerializeField] private Button m_ExitButton;
    [SerializeField] private TextMeshProUGUI m_PauseText;

    void Start()
    {
        DeactivateMenu();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ActivateMenu()
    {
        m_ResumeButton.gameObject.SetActive(true);
        m_ExitButton.gameObject.SetActive(true);
        m_PauseText.gameObject.SetActive(true);
    }

    public void DeactivateMenu()
    {
        m_ResumeButton.gameObject.SetActive(false);
        m_ExitButton.gameObject.SetActive(false);
        m_PauseText.gameObject.SetActive(false);
    }
}
