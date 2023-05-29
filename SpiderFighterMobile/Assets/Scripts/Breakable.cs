using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public bool hasParticleSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.magnitude < 0.0f)
        {
            if (Mathf.Approximately(GetComponent<Rigidbody>().velocity.magnitude, 0.0f))
            {
                if (hasParticleSystem)
                {
                    CreateParticleSystem();
                }
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void CreateParticleSystem()
    {
        // Code to create and configure the particle system goes here
    }
}
