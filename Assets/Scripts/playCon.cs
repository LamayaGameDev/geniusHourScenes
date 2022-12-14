using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;
using UnityEngine.UI;
public class playCon : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camHolder;
    public float speed, sensitivity, maxForce, jumpForce, snappiness;
    private Vector2 move, look;
    private Vector3 targetVelocityLerp;
    private float lookRotation;
    public bool grounded;
    public PhotonView view;
    public Text nameText;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            nameText.text = PhotonNetwork.NickName;
        }
        else
        {
            nameText.text = view.Owner.NickName;
        }
        
       
       

    }
    
   
    

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        look = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (view.IsMine)
        { 
            Jump(); 
        }
        
        
    }

    private void FixedUpdate()
    {
        if (view.IsMine)
        {
            Move();            
        }

        else if (!view.IsMine && camHolder.transform.GetChild(0).GetComponent<Camera>().enabled)
        {
            // Destroy(camHolder);
            camHolder.transform.GetChild(0).GetComponent<Camera>().enabled = false;
        }

    }

    void Jump()
    {

        Vector3 jumpForces = Vector3.zero;

        if (grounded)
        {
            jumpForces = Vector3.up * jumpForce;
        }

        rb.AddForce(jumpForces, ForceMode.VelocityChange);

    }

    void Move()
    {
        Vector3 currentVelocity = rb.velocity;
        Vector3 targetVelocity = new Vector3(move.x, 0, move.y);
        targetVelocity *= speed;

        //Align direction
        targetVelocity = transform.TransformDirection(targetVelocity);

        targetVelocityLerp = Vector3.Lerp(targetVelocityLerp, targetVelocity, snappiness); //-------- This line was changed

        //Calculate forces
        Vector3 velocityChange = (targetVelocityLerp - currentVelocity); //------------------------------------- This line was changed

        velocityChange = new Vector3(velocityChange.x, 0, velocityChange.z);

        //Limit force
        Vector3.ClampMagnitude(velocityChange, maxForce);

        rb.AddForce(velocityChange, ForceMode.VelocityChange);
    }










    void Look()
    {
        transform.Rotate(Vector3.up * look.x * sensitivity);


        lookRotation += (-look.y * sensitivity);
        lookRotation = Mathf.Clamp(lookRotation, -90, 90);
        camHolder.transform.eulerAngles = new Vector3(lookRotation, camHolder.transform.eulerAngles.y, camHolder.transform.eulerAngles.z);
    }


    void LateUpdate()
    {
        Look();
    }

    public void SetGrounded(bool state)
    {
        grounded = state;
    }




}
