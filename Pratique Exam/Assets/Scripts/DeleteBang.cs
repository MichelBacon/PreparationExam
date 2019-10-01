using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBang : MonoBehaviour {

    public int lifeSpan = 2;
    private float timeLeftToLive;

    // Use this for initialization
    void Start () {
        timeLeftToLive = lifeSpan;
    }
	
	// Update is called once per frame
	void Update () {
        ApplyLifeSpan();
    }

    private void ApplyLifeSpan()
    {
        timeLeftToLive -= Time.deltaTime;
        if (timeLeftToLive < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
