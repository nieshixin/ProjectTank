using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gunner : MonoBehaviour
{
    [SerializeField] GameObject commander;
    [SerializeField] GameObject turrent;
    [SerializeField] GameObject paoguan;

    [SerializeField] float depression =0;
    [SerializeField] float elavation = 0;

    public float speed;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        turrent.transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * speed);

        if (Input.GetAxis("Vertical") <0)  //depression
        {


            if (Input.GetAxis("Vertical") + depression >= -8)
            {
                depression += Input.GetAxis("Vertical");
                paoguan.transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * speed);

                transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * speed);

                elavation += Input.GetAxis("Vertical");
            }
        }

        if (Input.GetAxis("Vertical") > 0)   //elavation
        {

            if (Input.GetAxis("Vertical") * speed + elavation <= 35)
            {
                elavation += Input.GetAxis("Vertical");
                paoguan.transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * speed);

                transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * speed);

                depression += Input.GetAxis("Vertical");
            }
        }
        

        Debug.Log(paoguan.transform.localEulerAngles.x);
        


        GM._instance.setAngleText(1, transform.parent.transform.eulerAngles.y);
    }
}
