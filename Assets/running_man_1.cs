using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class running_man_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject guy;


    public List<Transform> path = new List<Transform>();
    public float loop_time;
    Vector3[] pathv3;

    void Start()
    {

        pathv3 = new Vector3[path.Count];
        for (int i = 0; i < path.Count; i++)
        {
            pathv3[i] = path[i].position;
        }
            GameObject go = (GameObject)Instantiate(guy, path[0].position, Quaternion.identity);

        go.transform.DOPath(pathv3, loop_time, PathType.Linear, PathMode.Full3D, 10, null).SetLoops(100,LoopType.Yoyo).SetEase(Ease.Linear).Play();

        }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
