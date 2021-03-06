using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public ParticleSystem shellExplosion;

    private void OnCollisionEnter (Collision other)
    {
        ParticleSystem fire = Instantiate (shellExplosion , transform.position , Quaternion.identity);
        fire.Play ();
       
        Destroy (gameObject);
        Destroy (fire.gameObject , 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
