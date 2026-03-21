using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    /*
     Crie um script com uma variável public int vida = 100;.
Use um if para verificar: se a vida for menor ou igual a 0, exiba "Game Over" no
console.
     */
    public int vida = 100;


    void Start()
    {
        


    }

    
    void Update()
    {
        
        if(vida <= 0)
        {
            print("Sua vida chegou a 0, Game over");
        }
    }
}
