using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolumetricLines;

public class RayonLaser : MonoBehaviour
{
    public VolumetricLineBehavior laser;
    public Transform cible;
    // Start is called before the first frame update
    void Start()
    {
        laser = GetComponent<VolumetricLineBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        laser.StartPos = transform.position;
        laser.EndPos = cible.position;
    }
}
