using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    private GameManager _gameManager;



    void Start()
   {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
   }
   private void OnCollisionEnter(Collision other)
   {
        //change variables so they correspond to game
        if(other.gameObject.tag == "Bullet")
        {
             _gameManager.UpdateScore();
             Destroy(other.gameObject);
             Destroy(this.gameObject);   
        }    
        
   }
}
