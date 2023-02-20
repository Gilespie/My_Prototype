using UnityEngine;
using UnityEngine.Events;

public class TriggerVoice : MonoBehaviour
{
    public UnityEvent OnTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnTrigger.Invoke();
            Destroy(gameObject); 
        }
    }
}
