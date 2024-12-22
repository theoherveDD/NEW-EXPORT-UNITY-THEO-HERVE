using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReceptacleManager : MonoBehaviour
{
    public bool hasInput = false; 
    public string soundType; 
    public AudioSource audioSource;
    private Renderer rend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Input"))
        {


            
            hasInput = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Input"))
        {
            hasInput = false; 
        }
    }
}