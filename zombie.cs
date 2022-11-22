using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject grrr;
    public AudioSource Violin;
    private void OnTriggerEnter(Collider other)
    {
        grrr.SetActive(true);
        Violin.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        grrr.SetActive(false);       
        Violin.Stop();
    }
}
