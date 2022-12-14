using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GlobalVariableStorage : MonoBehaviour
{
    public PhotonView view; 
    public bool globalVar;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

        
        
        
        
        
    }
    

}
/*if (view.IsMine)
{
    Move();
}

else if (!view.IsMine && camHolder.transform.GetChild(0).GetComponent<Camera>().enabled)
{
    // Destroy(camHolder);
    camHolder.transform.GetChild(0).GetComponent<Camera>().enabled = false;
}*/
