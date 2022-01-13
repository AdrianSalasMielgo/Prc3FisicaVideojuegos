using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float moveSpeed;
    //public float DoorSpeed;
    private bool isGorunded = false;
    private float force;

    private int life;
    private float stamina;

    public Slider BarraVida;
    public Slider BarraEstamina;

    public Rigidbody rb;
    // Variables for the open and close door
    /*
    public GameObject Door;
    public GameObject Door1;
    public GameObject TC;
    public GameObject DA;
    public GameObject DA1;
    public GameObject DA2;
    */

    public WinCondition win;

    void Start()
    {
        life = 100;
        stamina = 10;
        moveSpeed = 5;
        force = 15;
    }

    void Update()
    {
        Move(moveSpeed);
        KeyControl();
        //BarraVida.value = life;
        //BarraEstamina.value = stamina;

    }

    void DañoRecivido()
    {

    }

    void KeyControl()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGorunded == true && stamina >= 2)
        {
            Jump();
        }
        if (isGorunded == false)
        {
            rb.AddForce(0, -2.5f, 0, ForceMode.Force);
        }

        // Run
        if (Input.GetKey(KeyCode.LeftShift) && stamina >= 0)
        {
            Move(moveSpeed * 2);
            Run();
        }
        else if (!(Input.GetKey(KeyCode.LeftShift)))
        {
            stamina += 1 * Time.deltaTime;
            BarraEstamina.value = stamina;
            if (stamina >= 10)
            {
                stamina = 10;
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
        stamina -= 2;
        if (stamina <= 0)
        {
            stamina = 0;
        }
    }

    void Run()
    {
        stamina -= 3*Time.deltaTime;
        BarraEstamina.value = stamina;
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