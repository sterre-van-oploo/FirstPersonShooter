using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag.Equals("NPC"))
                {
                    Destroy(hit.collider.gameObject); 
                }
            }
        }
    }
}
