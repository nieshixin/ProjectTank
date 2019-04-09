using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fire : MonoBehaviour
{
    public GameObject shellObj;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {  // left button pressed

            GameObject go = (GameObject)Instantiate(shellObj, shellObj.transform.position, Quaternion.identity);

            go.SetActive(true);
            go.transform.DOMove(go.transform.position + transform.up * range, 1f);
            Destroy(go, 3.0f);
        }
    }
}
