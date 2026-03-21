using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    /*
     12. Verificação dupla (AND)
Crie bool temArma = true; e bool temMunicao = false;
Se ambos forem verdadeiros, exiba "Pode atirar".

     */

    [SerializeField]private bool temArma = true;
    [SerializeField] private bool temMunição = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        if( temArma && temMunição)
        {
            print("Pode atirar!");

        }
     else
        {
            print("Não pode atirar!");
        }
    
    
    }
}
