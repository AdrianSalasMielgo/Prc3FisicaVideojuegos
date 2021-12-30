using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECube : MonoBehaviour
{
    public GameObject player;

    private isLive live;

    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }

        live = player.GetComponent<isLive>();
    }

    // Update is called once per frame
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            live.onDestroy();
        }
    }
}
