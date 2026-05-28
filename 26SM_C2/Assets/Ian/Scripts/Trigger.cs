using System;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
        onEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
        onExit.Invoke();
    }
}
