using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    private Camera m_Camera;
    //private Vector3 pos = new Vector3(1920 / 2, 1080 / 2);

    void Start()
    {
        m_Camera = GetComponent<Camera>();   
    }

    // Update is called once per frame
    void Update()
    {

        //var ray = m_Camera.ScreenPointToRay(pos);
        //Debug.DrawRay(ray.origin, ray.direction * 30, Color.cyan);
        //var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(transform.position, transform.forward * 15f, Color.cyan);

        //RaycastHit hit;

        //Physics.Raycast(ray, out hit);
        //    if(hit.collider)
        //{
        //    Debug.Log(hit.collider.name);
        //}
    }
}
