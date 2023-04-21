using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsion : MonoBehaviour
{
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        // Affecté par la masse
        rig.AddForce(Vector2.right * 10.0f, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
