using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Transform m_Camera;
    public bool IsShake = false;
    private Vector3 m_Default;

    void Start()
    {
        m_Camera = GetComponent<Transform>();
    }

    void Update()
    {
        if(IsShake)
        {
            StartCoroutine(Shake(2,1));
        }
    }
    public IEnumerator Shake(float duration, float magnitude)
    {
        float elapsed = 0f;

        m_Default = m_Camera.localPosition;

        while (elapsed < duration)
        {
            float x = Random.Range(-0.5f, 0.4f) * magnitude;
            float y = Random.Range(-0.3f, 0.3f) * magnitude;

            m_Camera.localPosition = new Vector3(x, y, -1.692f);
            elapsed += Time.deltaTime;
            yield return 0;
        }
        m_Camera.localPosition = m_Default;
    }
}
