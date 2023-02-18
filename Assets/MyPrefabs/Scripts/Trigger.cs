using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public event UnityAction OnEvent;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnEvent?.Invoke();
            Destroy(gameObject);
        }
    }
}
