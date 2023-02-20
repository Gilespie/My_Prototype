using UnityEngine;

public class Speak : MonoBehaviour
{
    [SerializeField] private AudioSource m_Voice;
    public VoiceList list;

    private void Awake()
    {
        m_Voice.volume = 0.5f;    
    }

    void Start()
    {
        m_Voice.PlayOneShot(list.Robot_Start);
    }
    
    public void RobotAmazing()
    {
        m_Voice.PlayOneShot(list.Robot_Amazing);
    }

    public void RobotBridge()
    {
        m_Voice.PlayOneShot(list.Robot_Bridge);
    }

    public void RobotDead()
    {
        m_Voice.PlayOneShot(list.Robot_Dead);
    }

    public void RobotStress()
    {
        m_Voice.PlayOneShot(list.Robot_Stress);
    }

    public void RobotHigh()
    {
        m_Voice.PlayOneShot(list.Robot_High);
    }

    public void RobotTimer()
    {
        m_Voice.PlayOneShot(list.Robot_Timer);
    }

    public void RobotWater()
    {
        m_Voice.PlayOneShot(list.Robot_Water);
    }
}
