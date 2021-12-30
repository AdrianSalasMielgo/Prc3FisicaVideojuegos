using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCPlayer: MonoBehaviour
{
    public GameObject Player;
    int cont = 1;
    public int op;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RayCastFunction();
    }

    void RayCastFunction()
    {
        // Does the ray intersect any objects excluding the player layer
        // right hand
        Debug.DrawRay(transform.position, transform.forward * 1f, Color.red);
        Debug.DrawRay(transform.position, transform.right * 1f, Color.yellow);

        if (Physics.Raycast(transform.position, transform.forward, 1))
        {
            Debug.DrawRay(transform.position, transform.forward * 1f, Color.green);
        }

        if (Physics.Raycast(transform.position, transform.right, 1))
        {
            Debug.DrawRay(transform.position, transform.right * 1f, Color.green);
        }

        if (Physics.Raycast(transform.position, transform.right, 1))
        {
            cont = 0;
        }

        if ((Physics.Raycast(transform.position, transform.forward, 1)) && !(Physics.Raycast(transform.position, transform.right, 1)))
        {
            //transform.eulerAngles += new Vector3(0, -90, 0);
            op = 1;
            Player.GetComponent<Move>().Rotate();
        }

        if ((Physics.Raycast(transform.position, transform.forward, 1)) && (Physics.Raycast(transform.position, transform.right, 1)))
        {
            //transform.eulerAngles += new Vector3(0, -90, 0);
            op = 1;
            Player.GetComponent<Move>().Rotate();
        }

        if (!(Physics.Raycast(transform.position, transform.right, 1)) && cont == 0)
        {
            //transform.eulerAngles += new Vector3(0, 90, 0);
            cont = 1;
            op = 0;
            Player.GetComponent<Move>().Rotate();
        }
        /*
         * left hand
        Debug.DrawRay(transform.position, transform.forward * 1f, Color.red);
        Debug.DrawRay(transform.position, -transform.right * 1f, Color.yellow);

        if (Physics.Raycast(transform.position, transform.forward, 1))
        {
            Debug.DrawRay(transform.position, transform.forward * 1f, Color.green);
        }

        if (Physics.Raycast(transform.position, -transform.right, 1))
        {
            Debug.DrawRay(transform.position, -transform.right * 1f, Color.green);
        }

        if (Physics.Raycast(transform.position, -transform.right, 1))
        {
            cont = 0;
        }

        if ((Physics.Raycast(transform.position, transform.forward, 1)) && !(Physics.Raycast(transform.position, -transform.right, 1)))
        {
            //transform.eulerAngles += new Vector3(0, -90, 0);
            op = 1;
            Player.GetComponent<Move>().Rotate();
        }

        if ((Physics.Raycast(transform.position, transform.forward, 1)) && (Physics.Raycast(transform.position, -transform.right, 1)))
        {
            //transform.eulerAngles += new Vector3(0, -90, 0);
            op = 1;
            Player.GetComponent<Move>().Rotate();
        }

        if (!(Physics.Raycast(transform.position, -transform.right, 1)) && cont == 0)
        {
            //transform.eulerAngles += new Vector3(0, 90, 0);
            cont = 1;
            op = 0;
            Player.GetComponent<Move>().Rotate();
        }
        */
    }
}
