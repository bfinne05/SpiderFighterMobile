using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public bool hasParticleSystem; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            if (hasParticleSystem)
            {
                CreateParticleSystem();
            }
            Destroy(gameObject);
        }
    }

    void CreateParticleSystem()
    {
        
    }
}
