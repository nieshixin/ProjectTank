using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gunner : MonoBehaviour
{
    [SerializeField] GameObject commander;
    [SerializeField] GameObject turrent;
    public float speed;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        turrent.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * speed);

        GM._instance.setAngleText(1, transform.parent.transform.eulerAngles.y);
    }
}
