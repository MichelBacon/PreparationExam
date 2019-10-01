using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangScript : MonoBehaviour {

    public GameObject bangPrefab;
    private bool asFire = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetAxis("Fire1") != 0)
        {
            if(asFire != true)
            {
                GameObject bangObject = Instantiate(bangPrefab);
                asFire = true;
            }  
        }
        else
        {
            asFire = false;
        }
    }
}
