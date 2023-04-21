using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitesse : MonoBehaviour
{
    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        // Non affecté par la masse
        rig.velocity = Vector2.right * 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
