using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using UnityEngine;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField roomInput;
    //public InputField joinInput;

    public void CreateRoom()
    {
        Debug.Log("Creating...");
        PhotonNetwork.CreateRoom(roomInput.text);
    }

    public void JoinRoom()
    {
        Debug.Log("Joining...");
        PhotonNetwork.JoinRoom(roomInput.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("On Join...");
        PhotonNetwork.LoadLevel("asd");
    }
} 
