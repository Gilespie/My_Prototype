using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class OnInteractive : MonoBehaviour
{
    public static event UnityAction OnExplosive;
    [SerializeField] private GameObject m_Obj;
    [SerializeField] private Button buttonMinus;
    [SerializeField] private Button buttonPlus;
    [SerializeField] private TextMeshProUGUI m_Text;
    [SerializeField] private CharacterController m_Person;
    //[SerializeField] private Image m_Image;
    private float count;
    private bool IsActive = false;
    //private Vector3 maxScale = new Vector3(1, 1, 1);
    //private Vector3 minScale = new Vector3(0, 0, 0);
    //private float seconds;

    private void Start()
    {
        m_Obj.SetActive(false);
    }

    private void Update()
    {
        //transform.LookAt(m_Person.transform.position);
        
        if(IsActive)
        {
            count -= Time.deltaTime;
            m_Text.text = string.Format("{0:00}", count); 

            if(count < 0)
            {
                count = 0f;
                IsActive = false;
                OnExplosive?.Invoke();
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        m_Obj.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerExit(Collider other)
    {
        m_Obj.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
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
