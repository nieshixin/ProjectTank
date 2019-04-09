using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class target : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        //numberText = transform.GetChild(0).GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

            GM._instance.counter++;
            Debug.Log("Hit!  " );
            Destroy(gameObject);

       }
}
