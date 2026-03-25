using UnityEngine;

public class JogoSimples : MonoBehaviour
{

    [SerializeField] private int numeroSecreto;
   [SerializeField]private int numeroChute;
    bool jogando = true;
    int tentativas = 3;
    
    void Start()
    {
        print("O jogo começou!");
        print("Adivinhe um número entre 1 a 100!");
        print("Você tem 3 chances!");
        numeroSecreto = Random.Range(1, 101);
    }




    void Update()
    {

        if (Input.anyKeyDown && jogando)
        {

            tentativas--;
            
            {
                if (numeroChute > numeroSecreto)
                {
                    print(" Menos");
                }
                if (numeroChute < numeroSecreto)
                {
                    print("Mais");
                }

                if (numeroChute == numeroSecreto)
                {

                    print("Você acertou o número! era " + numeroSecreto);
                     print(" Você tentou: " + tentativas);
                    jogando = false;

                }
                if( tentativas <=0)
                {
                    print("O jogo acabou!Você gastou suas 3 chances!");
                    jogando = false;
                   
                }
            }
             
            
            
           

            


            
        }






    }
}
