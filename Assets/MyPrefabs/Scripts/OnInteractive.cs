using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class OnInteractive : MonoBehaviour
{
    public static event UnityAction OnExplosive;

    [SerializeField] private GameObject m_Obj;
    [SerializeField] private GameObject m_ObjFixing;
    [SerializeField] private Button m_ButtonMinus;
    [SerializeField] private Button m_ButtonPlus;
    [SerializeField] private TextMeshProUGUI m_Text;
    [SerializeField] private CharacterController m_Person;
    //[SerializeField] private Image m_Image;
    private float count;
    private bool IsActive = false;
    private bool IsFixing = false;
    //private Vector3 maxScale = new Vector3(1, 1, 1);
    //private Vector3 minScale = new Vector3(0, 0, 0);
    //private float seconds;

    private void Start()
    {
        m_ObjFixing.SetActive(false);
        m_Obj.SetActive(false);
        Takeable.OnIsTaking += Fixing;
    }

    private void Update()
    {
        if (IsActive)
        {
                count -= Time.deltaTime;
                m_Text.text = string.Format("{0:00}", count);

                if (count < 0)
                {
                    count = 0f;
                    IsActive = false;
                    OnExplosive?.Invoke();
                    gameObject.SetActive(false);
                }
     
        }
    }

    private void OnDestroy()
    {
        Takeable.OnIsTaking -= Fixing;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsFixing)
        {
            m_ObjFixing.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            m_Obj.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsFixing)
        {
            m_ObjFixing.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            m_Obj.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ChangeCountPlus()
    {
            count += 1f;

        if (count >= 5)
            count = 5;

            m_Text.SetText("" + count);
    }

    public void ChangeCountMinus()
    {
            count -= 1f;

        if (count <= 0 )
            count = 0;

            m_Text.SetText("" + count);
    }

    public void StartDetonation()
    {
         IsActive = true;
    }

    private void Fixing()
    {
        IsFixing = true;
    }

    //private void ChangeCount(float value)
    //{
    //    if (buttonPlus)
    //    {
    //        count += value;
    //        m_Text.SetText("{count}");
    //    }
    //    else if (buttonMinus)
    //    {
    //        count -= value;
    //        m_Text.SetText("{count}");
    //    }
    //}

    //IEnumerator StartFadeIn()
    //{
    //    m_Image.rectTransform.localScale = Mathf.Lerp(m_Image.rectTransform.localScale.x, m_Image.rectTransform.localScale.x/0, seconds);
    //    yield return null;
    //}
    //IEnumerator StartFadeOut()
    //{
    //    yield return null;
    //}
}
