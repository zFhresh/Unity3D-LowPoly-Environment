using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class AnimationTrigger : MonoBehaviour
{
    [SerializeField]UnityEvent AnimationFunction;
    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            AnimationFunction.Invoke();
        }
    }
}
