using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public float force = 5;

    // Update is called once per frame
   private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    //PrintName(hit.transform.gameObject);
                    Rigidbody rb;
                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        LauchIntoAir(rb);
                    }
                }
            }
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
    private void LauchIntoAir(Rigidbody rig)
    {
        rig.AddForce(rig.transform.up * force, ForceMode.Impulse);
    }
}
