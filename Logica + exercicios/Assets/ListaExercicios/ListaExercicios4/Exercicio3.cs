using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    /*
     3. Sistema de pontuação
 Crie public int pontos;
 Se pontos forem maiores que 100, mostre "Você venceu!"
     */

    public int pontos;

    void Start()
    {
        
    }

   
    void Update()
    {
        if ( pontos > 100)
        {
            print("Você venceu!");
        }


    }
}
