using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeadMenu : MonoBehaviour
{
    [SerializeField] private Button m_Exit;
    [SerializeField] private Button m_Restart;
    [SerializeField] private TextMeshProUGUI m_Text;

    void Start()
    {
        SceneTrancisional.OnFade += ActivateMenu;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        m_Exit.gameObject.SetActive(false);
        m_Restart.gameObject.SetActive(false);
        m_Text.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        SceneTrancisional.OnFade -= ActivateMenu;
    }

    private void ActivateMenu()
    {
        StartCoroutine(MenuShow());
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("FirstLevel");  
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator MenuShow()
    {
        yield return new WaitForSeconds(3f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        m_Exit.gameObject.SetActive(true);
        m_Restart.gameObject.SetActive(true);
        m_Text.gameObject.SetActive(true);
        StopCoroutine(MenuShow());
    }
}
