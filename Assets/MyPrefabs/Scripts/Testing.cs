using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private GameObject m_Spear;

    void Update()
    {
        //Ray raycamera = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(transform.position, transform.forward * 100f, Color.blue);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateSpear(); 
        }
    }

    private void CreateSpear()
    {
        Instantiate(m_Spear, transform.position, transform.rotation);
    }
}
