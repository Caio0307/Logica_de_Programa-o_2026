using UnityEngine;

public class Exercicio5 : MonoBehaviour
{
    /*
     5. Sistema de energia
Crie [SerializeField] private int energia = 30;
Se energia for menor que 20, exiba "Sem energia suficiente".
     */
    [SerializeField] private int energia = 30;


    void Start()
    {
        
    }

    
    void Update()
    {
       if ( energia < 20)
        {
            print("sem energia!");
        }
    }
}
