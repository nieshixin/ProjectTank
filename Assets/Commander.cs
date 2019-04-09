using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander : MonoBehaviour
{
    Vector2 rotation = new Vector2(0, 0);
    public float speed = 0.1f;

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
      //  rotation.x += -Input.GetAxis("Mouse Y");

           
            transform.eulerAngles = (Vector2)rotation * speed;

        GM._instance.setAngleText(0, transform.eulerAngles.y);
    }
}
