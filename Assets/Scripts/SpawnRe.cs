using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRe : MonoBehaviour
{
    string tagNAme = "Player";
    [SerializeField] private Transform respawnPoint;
    public GameObject objectToFind;
    void OnTriggerEnter(Collider other)
    {
       objectToFind = GameObject.FindGameObjectWithTag(tagNAme);    
       objectToFind.transform.position = respawnPoint.transform.position;
    }
}
