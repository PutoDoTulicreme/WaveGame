using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour
{
    public Image gameOverText;
    public int score;
    private Rigidbody2D player;
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
            gameOverText.gameObject.SetActive(true); // Activate the "Game Over" text
            RectTransform rectTransform = gameOverText.GetComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            rectTransform.pivot = new Vector2(0.5f, 0.5f);
            rectTransform.anchoredPosition = Vector2.zero;
        } else {
            score -= 1;
        }
         // Exemplo de redução de 10 pontos, você pode ajustar conforme necessário
        Debug.Log("Player Score: " + score);
    }
}
