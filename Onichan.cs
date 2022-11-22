using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onichan : MonoBehaviour
{
    public GameObject colider;
    public AudioSource Audio;
    private void OnTriggerEnter(Collider other)
    {
      
        
    }
    private void OnTriggerExit(Collider other)
    {
        Audio.Play();
        colider.SetActive(false);
    }
}
