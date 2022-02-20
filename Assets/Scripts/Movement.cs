using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float p_speed = 10.0f;
    public float p_rotation_Speed = 100.0f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * p_speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * p_rotation_Speed * Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);
        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
