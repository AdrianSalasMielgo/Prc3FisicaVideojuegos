using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAir : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        agente.destination = Player.position;
    }
}
