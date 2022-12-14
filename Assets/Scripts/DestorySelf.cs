using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestorySelf : MonoBehaviour
{
    public GameObject gameObject;
    public bool timerStop;
    void Start()
    {
        timerStop = false;
    }
    // Update is called once per frame
    void Update()
    {
        
        DestroyMe();
        
    }
    public bool timerEnd()
    {
        return timerStop;
    }

    public void DestroyMe()
    {     
        

        if (timerStop = true)
        {
            Destroy(gameObject);
        }
    }

}





