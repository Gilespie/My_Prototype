using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShotTimeRB : MonoBehaviour
{
    [SerializeField] private float m_Seconds;
    private Rigidbody m_RB;


    void Start()
    {
        m_RB = GetComponent<Rigidbody>();
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        m_RB.isKinematic = false;
        yield return new WaitForSeconds(m_Seconds);
        m_RB.isKinematic = true;
        StopCoroutine("Delay");
    }
}
