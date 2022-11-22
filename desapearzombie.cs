using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desapearzombie : MonoBehaviour
{
   
    public GameObject zombie;
    public AudioSource violin;
    public GameObject box;
    public GameObject box1;

    private void OnTriggerEnter(Collider other)
    {
   
    }
    private void OnTriggerExit(Collider other)
    {
       
        zombie.SetActive(false);
        violin.Stop();
        box.SetActive(false);
    }
}
