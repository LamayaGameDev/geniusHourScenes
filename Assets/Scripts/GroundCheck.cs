using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GroundCheck : MonoBehaviour
{
    public playCon playerController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return;

        playerController.SetGrounded(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return;

        playerController.SetGrounded(false);


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
            return;

        playerController.SetGrounded(true);


    }
}
