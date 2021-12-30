using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESphere : MonoBehaviour
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
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            live.onDestroy();
        }
    }
}
