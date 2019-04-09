using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gunner : MonoBehaviour
{
    //crew reference
    [SerializeField] Commander commander;
    [SerializeField] Driver driver;

    [SerializeField] GameObject turrent;
    [SerializeField] GameObject paoguan;

    [SerializeField] float depression =0;
    [SerializeField] float elavation = 0;

    public float turrent_rotation_speed;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;

      
        if (Input.GetAxis("Horizontal") != 0)
        {
           float delta_rot = Input.GetAxis("Horizontal") + Input.GetAxis("Horizontal2")*driver.traverse_speed;




            turrent.transform.Rotate(Vector3.up * delta_rot * turrent_rotation_speed); //turning turrent


        }


        if (Input.GetAxis("Vertical") <0)  //depression
        {


            if (Input.GetAxis("Vertical") + depression >= -8)
            {
                depression += Input.GetAxis("Vertical");
                paoguan.transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * turrent_rotation_speed);

                transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * turrent_rotation_speed);

                elavation += Input.GetAxis("Vertical");
            }
        }

        if (Input.GetAxis("Vertical") > 0)   //elavation
        {

            if (Input.GetAxis("Vertical") * turrent_rotation_speed + elavation <= 35)
            {
                elavation += Input.GetAxis("Vertical");
                paoguan.transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * turrent_rotation_speed);

                transform.Rotate(Vector3.left * Input.GetAxis("Vertical") * turrent_rotation_speed);

                depression += Input.GetAxis("Vertical");
            }
        }
        

      
        


        GM._instance.setAngleText(1, transform.parent.transform.eulerAngles.y);
    }
}
