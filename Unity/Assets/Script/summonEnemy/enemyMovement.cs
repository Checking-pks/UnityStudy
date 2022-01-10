using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{
    private NavMeshAgent nav;
    private GameObject Player;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        nav.SetDestination(Player.transform.position);
        
    }
}
