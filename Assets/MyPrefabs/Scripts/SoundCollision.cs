using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundCollision : MonoBehaviour
{
    [SerializeField] private AudioClip[] m_Audios;
    private AudioSource m_AS;
    private int m_IndexRandom;

    private void Start()
    {
        m_AS = GetComponent<AudioSource>();
        m_IndexRandom = Random.Range(0, m_Audios.Length);
        GetComponent<AudioSource>().clip = m_Audios[m_IndexRandom];
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_AS.volume = collision.impulse.magnitude * 0.01f;
        m_AS.Play();
    }
}