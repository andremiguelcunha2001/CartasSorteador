using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartas : MonoBehaviour
{
    string[] Carta1 = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Dama", "Às", "Valete", "Rei"};
    string[] Carta2 = new string[] {"Ouros", "Espadas", "Copas", "Paus"};
    string MostrarCarta1;
    string MostrarCarta2;

    void Start()
    {
      Iniciar();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Código a executar se o jogador pressionar a tecla ESPAÇO
           string MostrarCarta1 = Carta1[Random.Range(0, Carta1.Length)]; //Seleciona aleatoriamente um valor entre 2, 3, 4, 5, 6, 7, 8, 9, 10, Dama, Às, Valete e Rei
           string MostrarCarta2 = Carta2[Random.Range(0, Carta2.Length)]; //Seleciona aleatoriamente um valor dentre Ouros, Espadas, Copas, Paus
           Debug.Log("A carta sorteada foi " + MostrarCarta1 + " de " + MostrarCarta2); //Exibe o resultado do sorteio
           Iniciar(); //Retoma o script ao seu início possibilitando que o jogador sorteie mais cartas
        }
    }

      void Iniciar()
    {  
        Debug.Log("Pressiona a tecla ESPAÇO para sortear aleatoriamente uma carta do baralho"); //Exibe as instruções para sortear uma carta
    }
}