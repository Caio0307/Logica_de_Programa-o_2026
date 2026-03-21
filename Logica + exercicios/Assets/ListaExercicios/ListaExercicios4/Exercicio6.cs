using UnityEngine;

public class Exercicio6 : MonoBehaviour
{
    /*
     6. Ataque crítico
 Crie int danoBase = 10; e bool critico = true;
 Se for crítico, multiplique o dano por 2.
     */

    int danoBase = 10;
    bool critico = true;


    void Start()
    {
        if (critico)
        {
            danoBase *= 2;
            print("Alerta de dano critico! seu dano foi de 10 para: " + danoBase);
        }
    }

    void Update()
    {
    
        


    }
}
