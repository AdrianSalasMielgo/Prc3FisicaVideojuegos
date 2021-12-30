using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Open()
    {
        D.transform.position += new Vector3(-5, 0, 0);
        //Door1.transform.position += new Vector3(5, 0, 0);
    }

    // Close the Door
    void Close()
    {
        D.transform.position += new Vector3(5, 0, 0);
        //Door1.transform.position += new Vector3(-5, 0, 0);
    }
}
