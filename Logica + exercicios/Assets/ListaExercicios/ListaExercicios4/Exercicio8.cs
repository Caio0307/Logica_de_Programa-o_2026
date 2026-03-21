using UnityEngine;

public class Exercicio8 : MonoBehaviour
{
    /*
     8. Comparação de níveis
Crie int nivelJogador = 5; e int nivelInimigo = 8;
Se jogador >= inimigo, exiba "Pode lutar", senão "Muito perigoso".

     */
    [SerializeField]private int nivelJogador = 5;
    [SerializeField ]private int nivelInimigo = 8;                   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (nivelJogador >= nivelInimigo)
        {
            print("Pode Lutar");

        }
        else
        {
            print("Muito perigoso");
        }
    }
}
