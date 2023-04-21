using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        // Param�trer la propri�t� linear drag pour limiter la vitesse maximum ET le ralentir
        rig.AddForce(Vector2.right * 5.0f);
        rig.AddTorque(1.0f);
    }
}
