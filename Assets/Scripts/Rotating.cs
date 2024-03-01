using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    // Start is called before the first frame update
   using UnityEngine;

public class rotatePlayer : MonoBehaviour
{
    public float speed_of_rotating;
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.Rotate(0, 0, -speed_of_rotating);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            transform.Rotate(0, 0, speed_of_rotating);
        }
    }
}