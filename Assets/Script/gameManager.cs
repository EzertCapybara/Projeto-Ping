using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{

    public int point1;
    public int point2;
    public TMP_Text points_player1;
    public TMP_Text points_player2; 
   
    void Start()
    {

            point1 = 0; // Inicializa a pontuação do jogador 1 como e

            point2 = 0; // Inicializa a pontuação do jogador 2 como e


    }

    void Update()
    {
            // Atualiza o texto dos componentes Text para exibir as pontuações atu


            points_player1.text = point1.ToString(); // Converte a pontuação de

            points_player2.text = point2.ToString(); // Converte a pontuação de

    }

}

