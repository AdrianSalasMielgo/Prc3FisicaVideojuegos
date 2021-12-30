using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float DoorSpeed;
    public bool isGorunded = false;
    public float force;

    public int life;
    public float stamina;

    public Rigidbody rb;

    // Variables for the open and close door
    public GameObject Door;
    public GameObject Door1;
    public GameObject TC;
    public GameObject DA;
    public GameObject DA1;
    public GameObject DA2;

    public WinCondition win;

    void Start()
    {
        life = 100;
        stamina = 100;
        moveSpeed = 5;
        force = 15;
    }

    void Update()
    {
        Move(moveSpeed);
        KeyControl();
    }

    void KeyControl()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGorunded == true)
        {
            Jump();
        }
        if (isGorunded == false)
        {
            rb.AddForce(0, -2.5f, 0, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftShift) && stamina >= 0)
        {
            Move(moveSpeed * 5);
            Run();
        }
        else if (!(Input.GetKey(KeyCode.LeftShift)))
        {
            stamina++;
            if (stamina >= 100)
            {
                stamina = 100;
            }
        }
    }

    void Move(float moveSpeed)
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = transform.right * x + transform.forward * z;
        dir *= moveSpeed;
        dir.y = rb.velocity.y;

        rb.velocity = dir;
    }

    void Jump()
    {
        isGorunded = false;
        rb.AddForce(0, force, 0, ForceMode.Impulse);
    }

    void Run()
    {
        stamina--;
        if(stamina <= 0)
        {
            stamina = 0;
            Move(moveSpeed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            //Destroy(collision.collider.gameObject);

            isGorunded = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        /*
        if (collider.CompareTag("TriggerCubeDoor"))
        {
            //moveDoor();
        }

        if (collider.CompareTag("Desactivate"))
        {
            //RemoveDoor();
            TC.SetActive(false);
            DA.SetActive(false);
            DA1.SetActive(false);
            DA2.SetActive(false);
        }

        if (collider.CompareTag("Win"))
        {
            win.PlayerWIn();
        }
        */
    }

    void OnTriggerExit(Collider collider)
    {
        /*
        if (collider.CompareTag("TriggerCubeDoor"))
        {
            //RemoveDoor();
        }
        */
    }

    /*
    // Open the Door
    void moveDoor()
    {
        Door.transform.position += new Vector3(-5, 0, 0);
        Door1.transform.position += new Vector3(5, 0, 0);
    }

    // Close the Door
    void RemoveDoor()
    {
        Door.transform.position += new Vector3(5, 0, 0);
        Door1.transform.position += new Vector3(-5, 0, 0);
    }
    */
}