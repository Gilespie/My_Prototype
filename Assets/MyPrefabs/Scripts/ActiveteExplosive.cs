using UnityEngine;

public class ActiveteExplosive : MonoBehaviour
{
    [SerializeField] private GameObject m_Obj;

    void Start()
    {
        m_Obj.SetActive(false);
        
        OnInteractive.OnExplosive += ActivateExplosive;
    }

    private void OnDestroy()
    {
        OnInteractive.OnExplosive -= ActivateExplosive;
    }

    private void ActivateExplosive()
    {
        m_Obj.SetActive(true);
    }
}
