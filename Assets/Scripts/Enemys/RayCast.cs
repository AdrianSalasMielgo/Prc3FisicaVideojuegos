using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public GameObject A;
    public GameObject Enemy;

    public Vector3 vector3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        Debug.DrawRay(transform.position, vector3 * 100f, Color.green);
        if (Physics.Raycast(transform.position, vector3, out hit) && hit.transform.tag == "Player")
        {
            Debug.DrawRay(transform.position, vector3 * 100f, Color.red);
            //Debug.Log("Did Hit With Player");
            //Enemy.GetComponent<Unit>().enabled = true;
            Enemy.GetComponent<NavMeshEnemy>().enabled = true;
        }
        else
        {
            //Debug.Log("Did not hit with Player");
            Enemy.GetComponent<Unit>().enabled = false;
            //Enemy.GetComponent<NavMeshEnemy>().enabled = false;
        }
    }
}
