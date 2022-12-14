using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class CountDownTimer : MonoBehaviourPunCallbacks, IPunObservable
{
    public float curT = 0f;
    public float strT = 10f;
    public bool timerStop;
    [SerializeField] Text countdownText;
    public GameObject spawnArea;
    
    void Start()
    {
        timerStop = false;
        curT = strT;
        
    }
    

        
   void Update()
   {
        Timer();

        
   }
        

    void Timer()
    {

        
        curT -= 1 * Time.deltaTime;
        countdownText.text = curT.ToString("0");
        if (curT <= 0)
        {
            curT = 0f;
            timerStop = true;
            if (timerStop = true)
            {
                DestroyImmediate(transform.GetChild(0).gameObject);
            }
            Destroy(GetComponent<Text>());

        }
    }





    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(curT);
        }
        else
        {
            curT = (float)stream.ReceiveNext();
        }

    }
    
}
