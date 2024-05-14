using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReducePoints()
    {
        // Reduzir os pontos do jogador
        if(score - 1 <= 0) {
            Destroy(player);
        }
        score -= 1; // Exemplo de redução de 10 pontos, você pode ajustar conforme necessário
        Debug.Log("Player Score: " + score);
    }
}
