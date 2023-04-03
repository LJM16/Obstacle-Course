using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
     [SerializeField] private int _hits = 5;
     [SerializeField] public TextMeshProUGUI Health;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            _hits--;
            Health.text = "Health: " + _hits.ToString();
        }    
    }

}
