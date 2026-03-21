using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    /*
     Crie float tempo = 120f;
 Se tempo <= 0, exiba "Tempo esgotado". 
     */
   [SerializeField] private float tempo = 120f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (tempo <= 0 )
        {
            print("tempo esgotado");
        }
    }
}
