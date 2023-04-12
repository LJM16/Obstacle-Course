using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Rigidbody projectile;
public float speed = 20;


public class GunScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiateProjectile = Instantiate(instantiate,transform.position,transform.rotation) as Rigidbody;
        }
    }
}
