using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshEnemy : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        agente.destination = Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
