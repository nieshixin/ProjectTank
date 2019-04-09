using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public static GM _instance;
    public int counter = 0;
    public Text commander, gunner, driver;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setAngleText(int tar, float angle) {
        if (tar == 0)
        {
            commander.text = "车长角度："+Mathf.FloorToInt(angle).ToString();
        }
        else if (tar == 1)
        {
            gunner.text = "炮手角度：" + Mathf.FloorToInt(angle).ToString();
        }
        else {
            driver.text = "驾驶员角度：" + Mathf.FloorToInt(angle).ToString();
        }
    }
}
