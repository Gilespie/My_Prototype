using UnityEngine;
using UnityEngine.Events;

public class Takeable : MonoBehaviour
{
    public static event UnityAction OnIsTaking;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            OnIsTaking?.Invoke();
            Destroy(gameObject);
        }
    }
}
