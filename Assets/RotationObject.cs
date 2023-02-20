using UnityEngine;

public class RotationObject : MonoBehaviour
{   
    private void Update()
    {
        Quaternion m_Angle = Quaternion.AngleAxis(10f * Time.deltaTime, Vector3.up);
        transform.rotation *= m_Angle;
    }
}
