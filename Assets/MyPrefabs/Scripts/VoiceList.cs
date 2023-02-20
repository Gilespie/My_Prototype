using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Voice List", menuName = "Scriptable Objects")]
public class VoiceList : ScriptableObject
{
    public AudioClip Robot_Start;
    public AudioClip Robot_Amazing;
    public AudioClip Robot_Dead;
    public AudioClip Robot_Stress;
    public AudioClip Robot_High;
    public AudioClip Robot_Water;
    public AudioClip Robot_Bridge;
    public AudioClip Robot_Timer;
}
