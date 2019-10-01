using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour {

    private Rigidbody rbd;
    private ParticleSystem particleSystem;
    public int SPEEDFACTOR = 10000;
    public int ROTATIONSCALE = 20;


    // Use this for initialization
    void Start () {
        rbd = gameObject.GetComponent<Rigidbody>();
        particleSystem = FindObjectOfType<ParticleSystem>();   
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponentInChildren<RotateHelix>().speed = 1000f;
        particleSystem.Stop();
		if(Input.GetAxis("Jump") != 0)
        {
            rbd.AddRelativeForce(new Vector3(0, 0, Input.GetAxis("Jump") * Time.deltaTime * SPEEDFACTOR * -1));
            gameObject.GetComponentInChildren<RotateHelix>().speed = Time.deltaTime * SPEEDFACTOR * 10;
            particleSystem.Play();
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            rbd.AddForceAtPosition(new Vector3(0, 0, Input.GetAxis("Vertical")) * Time.deltaTime * ROTATIONSCALE, new Vector3(0, 10, 0));
        }
    }
}
