using UnityEngine;

public class RandomSize : MonoBehaviour
{
    [SerializeField] private Transform[] m_Objs;

    void Start()
    {
        for(int i = 0; i < m_Objs.Length; i++)
        {
            m_Objs[i].transform.localScale = new Vector3(Random.Range(1f, 3f), Random.Range(1f, 2f), Random.Range(1f, 3f));
        }
    }
}
