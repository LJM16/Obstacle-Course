using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunScript : MonoBehaviour
{
    public float Speed = 20f;
    public float TimeTraveled = 5f;


	void Update () 
	{
		transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        Destroy(gameObject, TimeTraveled);
	}

}
