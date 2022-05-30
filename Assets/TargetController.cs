using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ParticleSystem targetExplosion;

    // Update is called once per frame
    private void OnCollisionEnter (Collision coll)
    {
        if (coll.collider.tag == "SHELL") {
            ParticleSystem fire = Instantiate (targetExplosion , transform.position , Quaternion.identity);
            fire.Play ();

            Destroy (gameObject);
            Destroy (fire.gameObject , 2.0f);
        }
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
