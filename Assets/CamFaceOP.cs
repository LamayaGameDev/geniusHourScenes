/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class CamFaceOP : MonoBehaviour
{

    public PhotonView view;
    public void Update()
    {

        if (view.IsMine) {
            Camera cam = Camera.main;

            transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward,
                cam.transform.rotation * Vector3.up);
        }
            
        
    }
}
*/
