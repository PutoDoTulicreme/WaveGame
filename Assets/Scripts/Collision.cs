using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private PlayerScore playerScore; // Referência ao script que controla a pontuação do jogador
    // Start is called before the first frame update
    void Start()
    {
     playerScore = FindObjectOfType<PlayerScore>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col){
        if(col.gameObject.tag.Equals("Bullet")){
            Destroy (col.gameObject);
            Destroy (gameObject);
        }
        else if (col.gameObject.tag.Equals("Player"))
        {
            playerScore.ReducePoints();
        } 
    }
}
