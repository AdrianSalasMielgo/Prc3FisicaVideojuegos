using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    //private GameObject[] bullets;
    private GameObject GO;
    public Rigidbody projectile;
    private Rigidbody InstantiatedProyectile;
    public int projectileSpeed;
    // Start is called before the first frame update
    void Start()
    {
        projectileSpeed = 20;
        //bullets = GameObject.FindGameObjectsWithTag("BalaPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        // Trigger
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            InstantiatedProyectile = Instantiate(projectile, transform.position, transform.rotation);
            InstantiatedProyectile.velocity = transform.TransformDirection(new Vector3(0, 0, projectileSpeed));
            Physics.IgnoreCollision(InstantiatedProyectile.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
        }

        //bullets = GameObject.FindGameObjectsWithTag("BalaPlayer");
        GO = GameObject.FindGameObjectWithTag("BalaPlayer");
        Destroy(GO, 0.5f);
        
        //Debug.Log(bullets.Length);
    }
}
