using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObj : MonoBehaviour
{
    public GameObject[] m_Objs;
    public GameObject[] m_ObjsSpawn;

    private void Awake()
    {
        Shuffle(m_Objs);
    }

    //void Start()
    //{
    //    for(int i = 0; i < m_ObjsSpawn.Length; i++)
    //    {
    //        m_ObjsSpawn[i] = m_Objs[i];

    //        Instantiate(m_Objs[i], transform.position, Quaternion.identity);
    //    }
    //}

    private void Shuffle(GameObject[] deck)
    {
        for (int i = 0; i < deck.Length; i++)
        {
            GameObject temp = deck[i];
            int index = Random.Range(0, deck.Length);
            deck[i] = deck[index];
            deck[index] = temp;
        }
    }
}
