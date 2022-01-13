using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCairenemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 vector3;
    public GameObject Enemy;
    public GameObject Player;
    public GameObject Disparador;
    public int timer;
    void Start()
    {
        vector3 = Player.transform.position - Enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.transform.position - Enemy.transform.position);
        vector3 = Player.transform.position - Enemy.transform.position;
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        //Debug.DrawRay(transform.position, vector3, Color.green);
        if (Physics.Raycast(transform.position, vector3, out hit, 30f) && hit.transform.tag == "Player")
        {
            Debug.DrawRay(transform.position, vector3, Color.red);

            if (timer <= 0)
            {
                Disparador.GetComponent<TriggerEnemy>().DispararPlayer();
                timer = 100;
            }
            else
            {
                timer -= 1;
            }

            //Debug.Log("Disparo");

            //Debug.Log("te toco");
            //Debug.Log("Did Hit With Player");
            //Enemy.GetComponent<Unit>().enabled = true;
            Enemy.GetComponent<NavMeshAir>().enabled = false;
        }
        else
        {
            Debug.DrawRay(transform.position, vector3, Color.green);

            //Debug.Log("Did not hit with Player");
            //Enemy.GetComponent<Unit>().enabled = false;
            Enemy.GetComponent<NavMeshAir>().enabled = true;
        }
    }
}
