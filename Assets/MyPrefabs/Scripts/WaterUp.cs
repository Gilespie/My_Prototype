using System.Collections;
using UnityEngine;

public class WaterUp : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    //[SerializeField] private Trigger m_Trigger;
    private Vector3 m_Direction;
    private Transform m_ObjTansform;


    private void Start()
    {
        m_Direction = new Vector3(transform.position.x, 49f, transform.position.z);
        m_ObjTansform = GetComponent<Transform>();
        //m_Trigger.OnEvent += StartEvent;
        OnInteractive.OnExplosive += StartEvent;
    }

    private void OnDisable()
    {
        //m_Trigger.OnEvent -= StartEvent;
        OnInteractive.OnExplosive -= StartEvent;
    }

    private void StartEvent()
    {
        StartCoroutine(WaterLevelUp());
    }

    IEnumerator WaterLevelUp()
    {
        while (m_ObjTansform.position.y != m_Direction.y)
        {
            m_ObjTansform.position = Vector3.Lerp(m_ObjTansform.position, m_Direction, m_Speed * Time.deltaTime);
            yield return null;
        }
    }
}
