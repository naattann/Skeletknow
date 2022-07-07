using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject camera;
    void Update()
    {

       

        if (Input.GetKey(KeyCode.D) && gameObject.transform.rotation.y > -0.7f)
        {
            
            transform.Rotate(0, -0.5f, 0);

        }

        if (Input.GetKey(KeyCode.A) && gameObject.transform.rotation.y < 0.7f)
        {

            transform.Rotate(0, 0.5f, 0);

        }

        if (Input.GetKey(KeyCode.W) && camera.transform.localPosition.z < -35 )
        {

            camera.transform.localPosition = camera.transform.localPosition + new Vector3(0, 0, 0.25f);

        }

        if (Input.GetKey(KeyCode.S) && camera.transform.localPosition.z > -45)
        {

            camera.transform.localPosition = camera.transform.localPosition + new Vector3(0, 0, -0.25f);

        }



    }
}
