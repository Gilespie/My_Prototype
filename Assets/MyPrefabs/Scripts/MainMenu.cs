using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button m_StartButton;
    [SerializeField] private Button m_ExitButton;
    
    public void StarGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
