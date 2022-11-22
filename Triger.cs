using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    public GameObject grrr;
    public GameObject colider;
    public AudioSource Violin;
    private void OnTriggerEnter(Collider other)
    {
     
    }
    private void OnTriggerExit(Collider other)
    {
        grrr.SetActive(true);
        Violin.Play();
        colider.SetActive(false);
    }
}
