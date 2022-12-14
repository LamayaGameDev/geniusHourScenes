using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    
    public float Delay = 10;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;
    




    void Start()
    {


        Vector3 randomPostion = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
    
        GameObject myPlayer = (GameObject)PhotonNetwork.Instantiate(this.playerPrefab.name, randomPostion, Quaternion.identity, 0);

        //myPlayer.GetComponentInChildren<Camera>().enabled = true;





    }



}
