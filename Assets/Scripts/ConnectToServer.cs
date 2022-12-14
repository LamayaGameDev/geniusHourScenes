using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks

{
    public float time = 3.5f;

    
    
        
        void Start()
        {

            PhotonNetwork.ConnectUsingSettings();

            
        }


        // Code to execute after the delay
   // Start is called before the first frame update

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}

