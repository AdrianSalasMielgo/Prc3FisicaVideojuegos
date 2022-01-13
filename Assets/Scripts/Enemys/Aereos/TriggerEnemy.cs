using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody projectile;
    private Rigidbody InstanciatedProjectile;
    public int projectileSpeed;
    private bool Fuego = false;

    void Start()
    {
        projectileSpeed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispararPlayer()
    {
        InstanciatedProjectile = Instantiate(projectile, transform.position, transform.rotation);
        InstanciatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, projectileSpeed));
        Physics.IgnoreCollision(InstanciatedProjectile.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
    }
}
