using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool isLocked = false;
    [SerializeField]bool isOpen = false;
    Animator anim;
    private void Awake() {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
    void OpenDoor()
    {
        if(!isOpen)
        {
            anim.SetTrigger("OpenDoor");
            isOpen = true;
        }
        else
        {
            anim.SetTrigger("CloseDoor");
            isOpen = false;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
           isPlayerNear = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
    bool isPlayerNear = false;
    void Update()
    {
        if(isPlayerNear)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                OpenDoor();
            }
        }
    }
    
}
