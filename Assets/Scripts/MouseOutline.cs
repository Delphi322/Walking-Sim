using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOutline : MonoBehaviour
{

    RaycastHit hit;

    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject == gameObject && Vector3.Distance(Camera.main.transform.position, transform.position) < 8)
            {
                GetComponent<Outline>().enabled = true;
            }
            else
                GetComponent<Outline>().enabled = false;
        }
        else
            GetComponent<Outline>().enabled = false;
    }
}
