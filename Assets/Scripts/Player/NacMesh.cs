using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NacMesh : MonoBehaviour
{
    public Transform Win;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agente = GetComponent<NavMeshAgent>();
        agente.destination = Win.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
