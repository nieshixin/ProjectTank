using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public Transform originPos;
    public float spread;
    public int density;
    public GameObject targetObj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < density; i++) {
            float tarX = Random.Range(-spread, spread);
            float tarZ = Random.Range(-spread, spread);
            GameObject go = (GameObject)Instantiate(targetObj, originPos.position + new Vector3(tarX, 0, tarZ), Quaternion.identity);
            go.transform.GetChild(0).GetComponent<TextMesh>().text = i.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
