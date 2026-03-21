using UnityEngine;

public class Exercicio13 : MonoBehaviour
{
    /*
     13. Verificação alternativa (OR)
Crie bool temChave = false; e bool portaDestravada = true;
Se um dos dois for verdadeiro, exiba "Acesso permitido".
     */
   [SerializeField]private bool temChave = false;
    [SerializeField]private bool portaDestravada = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(temChave && portaDestravada)
        {
            print("acesso permitido");
        }
        else
        {
            print("PA! ACESSO NEGADO!");
        }


    }
}
