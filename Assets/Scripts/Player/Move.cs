using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rb;
    float number;
    //int cont = 1;
    public GameObject RayCast;
    int opP;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveTry();
    }

    void MoveTry()
    {
        Vector3 dir = transform.forward * 1;

        dir *= moveSpeed;
        rb.velocity = dir;
    }
    public void Rotate()
    {
        opP =  RayCast.GetComponent<RCPlayer>().op;

        // right hand
        if(opP == 1)
        {
            transform.eulerAngles += new Vector3(0, -90, 0);
        }
        if(opP == 0)
        {
            transform.eulerAngles += new Vector3(0, 90, 0);
        }
        /*
         * left hand
        if(opP == 1)
        {
            transform.eulerAngles += new Vector3(0, 90, 0);
        }
        if(opP == 0)
        {
            transform.eulerAngles += new Vector3(0, -90, 0);
        }
        */
    }
}
