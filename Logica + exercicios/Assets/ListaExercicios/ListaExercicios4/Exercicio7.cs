using UnityEngine;

public class Exercicio7 : MonoBehaviour
{
    /*
     7. Porta aberta
Crie bool temChave = false;
Se temChave == true, exiba "Porta aberta" senão "Porta trancada".
     */
   [SerializeField]private bool temChave = false;
    void Start()
    {
        
        

    }

    
    void Update()
    {
        if(temChave == true)
        {
            print("Porta Aberta!");

        }
        else
        {
            print("Porta trancada!");
        }

    }
}
