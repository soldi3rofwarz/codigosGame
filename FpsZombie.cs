using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsZombie : MonoBehaviour
{
    /*public Transform ObjetcToFollow = null;
    public float speed = 5;*/
    Transform Player;
    UnityEngine.AI.NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        //ObjetcToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(Player.position);
        /*if (ObjetcToFollow == null) return;

        transform.position = Vector2.MoveTowards(transform.position, ObjetcToFollow.transform.position, speed*Time.deltaTime);
        transform.up =ObjetcToFollow.position-transform.position;*/
    }
}
