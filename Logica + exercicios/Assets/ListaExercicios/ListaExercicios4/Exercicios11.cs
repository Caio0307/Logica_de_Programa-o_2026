using UnityEngine;

public class Exercicios11 : MonoBehaviour
{
    /*
     Crie bool estaNoChao = true;
Se estiver no chão, exiba "Pode pular". 
     */
    [SerializeField]private bool estaNoChao = true;
    void Start()
    {
        
    }

   
    void Update()
    {
        if(estaNoChao)
        {
            print("Pode pular");

    
        
        }
        else
        {
            print("aguarde um pouco!");
        }
    
    
    
    }



}
