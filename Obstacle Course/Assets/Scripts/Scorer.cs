using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    public GameObject GameOverScreen;

    public GameObject FinishPanel;

     [SerializeField] private int _hits = 5;
     [SerializeField] public TextMeshProUGUI Health;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            _hits--;
            Health.text = "Health: " + _hits.ToString();
        }    

        if(_hits <= 0)
        {
            GameOverScreen.gameObject.SetActive(true);
        }

        if(other.gameObject.CompareTag("Finish"))
        {
            FinishPanel.gameObject.SetActive(true);
        }
    }

}
