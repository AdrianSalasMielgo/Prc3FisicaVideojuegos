using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaEnemigoAereo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject BaseArma;

    void Start()
    {
        BaseArma.transform.LookAt(Player.transform.position);
    }

    // Update is called once per frame
    private void Update()
    {
        BaseArma.transform.LookAt(Player.transform.position);
    }

}
