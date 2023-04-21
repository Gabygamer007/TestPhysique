using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIGarde : MonoBehaviour
{
    private UnityAction<object> ev_changementCouleur;
    private SpriteRenderer rendu;

    void Start()
    {
        ev_changementCouleur = new UnityAction<object>(ChangementCouleur);
        EventManager.StartListening("SautDuJoueur", ev_changementCouleur);
        rendu = GetComponent<SpriteRenderer>();
        Debug.Assert(rendu != null);
    }

    // Update is called once per frame

    private void ChangementCouleur(object obj)
    {
        if (obj.GetType() == typeof(Color))
        {
        Color col = (Color)obj;
        rendu.color = col;
        }
    }
}
