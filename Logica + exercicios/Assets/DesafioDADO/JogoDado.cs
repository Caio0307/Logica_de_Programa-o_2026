using UnityEngine;

public class JogoDado : MonoBehaviour
{

    /*
    jogo de rolar dados
    2 jogadores rolam o dado 2 dados
    quem tirar o nuemro mair ganha 1 ponto
    quem ganhar 3 primeior ganha o jogo 
     
     
     */

    int roundJogador1 = 0;
    int roundJogador2 = 0;

    int PlayerAzul;
    int PlayerVermelho;





    void Update()
    {




        if (Input.anyKeyDown)//se eu clicar qualquer tecla
        {
            //então os jogadores rolam o dado
            PlayerAzul = Random.Range(1, 7);
            PlayerVermelho = Random.Range(1, 7);

            print(" player azul tirou " + PlayerAzul);
            print("player vermelho tirou " + PlayerVermelho);

            if (PlayerAzul == PlayerVermelho)
            {//se der empate, eles rolam o dado novamente
                print("Os dois tiraram o mesmo número! rolem os dados de novo!");

            }
            if (PlayerAzul > PlayerVermelho)
            {
                roundJogador1 += 1;
                print("player azul ganhou a rodada!");
                print("placar player azul " + roundJogador1 + " X " + roundJogador2 + " player vermelho ");
            }

            if (PlayerVermelho > PlayerAzul)
            {
                roundJogador2 += 1;
                print("player vermelho ganhou a rodada!");
                print("placar player azul " + roundJogador1 + " X " + roundJogador2 + " player vermelho");
            }
            if (roundJogador1 == 3)
            {
                print("PLAYER AZUL GANHOU!!!!");

            }
            if (roundJogador2 == 3)
            {
                print("PLAYER VERMELHO GANHOU!!!!");
            }
            if (roundJogador1 == 3 || roundJogador2 == 3)
            {
                print("O JOGO TERMINOU");

            }
        }







    }
}

