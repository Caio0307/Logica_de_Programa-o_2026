using UnityEngine;
using UnityEngine.Video;

public class Exercicio2 : MonoBehaviour
{
    /*
     2. Dano recebido
   Crie uma variável [SerializeField] private int dano = 10; e subtraia de vida.
   Se a vida ficar abaixo de 50, mostre "Cuidado!".
     */

    [SerializeField] private int dano = 10;
    int vida = 100;


    void Start()
    {
        



    }

    
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            vida -= dano;
        }
        
        
        if (vida < 50 )
        {
            print("Tome Cuidado!");
        }




    }
}
