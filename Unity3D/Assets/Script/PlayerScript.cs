using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    [SerializeField]float Speed;
    float Horizontal;
    float Vertical;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Get horizontal and verticala
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        //  Move player for Z axis & use rigidbody
        rb.velocity = new Vector3(0, rb.velocity.y, Horizontal * Speed * -1);       
        anim.SetFloat("Horizontal", Mathf.Abs(Horizontal)); 
        MoveDirectionAnimation();
        Raycast();
    }
    public Vector3 RaycastOffSet;
    void Raycast() {
        Vector3 HitPoint = transform.position + RaycastOffSet + transform.forward * 1.5f;
         // Draw line for raycast
        Debug.DrawLine(transform.position + RaycastOffSet, transform.position + RaycastOffSet + transform.forward * 1.5f, Color.red);
        RaycastHit hit; // Raycast 3d for dedect object
        if(Physics.Raycast(transform.position + RaycastOffSet, transform.forward , out hit, 1.5f))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>(); //  IInteractable is interface
            if(interactable != null)
            {
                interactable.Interact();
            }
        }
    }
    

    void MoveDirectionAnimation()
    {
        if(Horizontal == 0)
        {
            return;
        }
        if (Horizontal < 0)
        {
           transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
