using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementTransformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        // T�l�portation du carr� � chaque FixedUpdate, puis la physique repousse le carr� vers la gauche, ce qui emp�che la p�n�tration
        // Si ton jeu a de la physique, ne pas utiliser (en g�n�ral)
        // Si vous devez l'utiliser, mettre kin�matique (pas dynamique)
        transform.position += Vector3.right * 0.05f;
    }
}
