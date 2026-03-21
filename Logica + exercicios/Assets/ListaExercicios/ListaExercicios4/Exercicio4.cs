using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    /*
     4. Verificação de velocidade
 Crie private float velocidade = 5f;
 Se velocidade > 10, exiba "Muito rápido!", senão "Velocidade normal".
     */
    [SerializeField]private float velocidade = 5f;

    void Start()
    {
        


    }

    
    void Update()
    {
        
        
        if (velocidade > 10)
        {
            print("Muito rápido!");
        }
        else
        {
            print("Velocidade normal!");
        }


    }
}
