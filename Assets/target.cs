using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour
{
    private TextMesh numberText;

    // Start is called before the first frame update
    void Start()
    {
        numberText = transform.GetChild(0).GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (int.Parse(numberText.text) == GM._instance.counter)
        {
            GM._instance.counter++;
            Debug.Log("Hit!  " + numberText.text);
            Destroy(gameObject);
        }
        else {
            Debug.Log("Miss!");
        }
    }
}
