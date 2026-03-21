using UnityEngine;

public class Exercicio9 : MonoBehaviour
{
    /*
     9. Sistema de moedas
 Crie [SerializeField] private int moedas = 50;
 Se moedas >= 100, exiba "Pode comprar item".
     */
    [SerializeField] private int moedas = 50;


    void Start()
    {
        
    }

  
    void Update()
    {
    if (moedas >= 100)
        {
            print("pode comprar item!");

        }
        else
        {
            print("não pode comprar item");
        }


    }
}
