using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public GameObject explosion;

    void Update()
    {
     
        if(Input.GetMouseButton(0))
        {
            Instantiate(explosion);
        }

    }
}
