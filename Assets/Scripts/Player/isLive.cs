using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isLive : MonoBehaviour
{
    public bool live = true;
    public void onDestroy()
    {
        live = false;
    }
}
