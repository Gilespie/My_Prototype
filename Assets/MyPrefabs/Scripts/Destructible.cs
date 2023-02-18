using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    //[SerializeField] private Vector3 m_position;
    [SerializeField] private GameObject m_PrefabBroken;
    [SerializeField] private int countpieces;
    [SerializeField] private bool IsActive;
    [SerializeField] private Transform[] m_Transforms;

    void Start()
    {
        IsActive = false;
        m_PrefabBroken.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(IsActive)
        {
            Activate();
        }
    }

    private void Activate()
    {
        for(int i = 0; i < countpieces; i++)
        {
            for (int j = 0; j < m_Transforms.Length; j++)
            {
                Instantiate(m_PrefabBroken, m_Transforms[i].position, m_Transforms[i].rotation);
                Debug.Log(countpieces);
            }
        }
        
        Destroy(gameObject);
    }
}
