using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
    public Rigidbody prefabShell;
    public Transform fireTransform;
    public int playerNum = 1;
    string fireName;

    // Update is called once per frame
    void Update()
    {
        fireName = "Fire" + playerNum;
        //if (Input.GetButtonDown("Fire1"))
        //{
           // Fire ();
        //}
        
    }

    void Fire ()
    {
        //Rigidbody shellInstance =
       // Instantiate (prefabShell , fireTransform.position , fireTransform.rotation) as Rigidbody;

        //shellInstance.velocity = 15.0f * fireTransform.forward;

        if (Input.GetButtonDown (fireName))
        {
            Fire ();
        }
    }
}
