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
        // Téléportation du carré à chaque FixedUpdate, puis la physique repousse le carré vers la gauche, ce qui empêche la pénétration
        // Si ton jeu a de la physique, ne pas utiliser (en général)
        // Si vous devez l'utiliser, mettre kinématique (pas dynamique)
        transform.position += Vector3.right * 0.05f;
    }
}
