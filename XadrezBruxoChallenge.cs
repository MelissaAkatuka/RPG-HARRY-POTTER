using System;

namespace RPG
{
  class ChessChallenge
  {
    public static void wizardChessChallenge()
    {
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                   XADREZ BRUXO                                |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                              Vamos ao jogo!                                   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Em meio ao caos, as luzes se acendem e você está em um grande tabuleiro    |");
      Console.WriteLine("| de xadrez. Do outro lado do tabuleiro há uma porta, porém para chegar         |");
      Console.WriteLine("| até ela e descobrir seus mistérios, temos que jogar o Xadrez Bruxo.           |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| As pessoas são peões em um tabuleiro de xadrez. Guiadas por mãos desconhecidas|");
      Console.WriteLine("| servem apenas para serem sacrificadas por um objetivo maior.                  |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|                    Suba na sua peça e vamos ao jogo!                          |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.WriteLine("Pressione Enter para continuar");
      Console.ReadLine();

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                             XADREZ DE BRUXO!                                  |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| Agora, você tem 3 opções:                                                     |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| (1) Cavalo do Rei                                                             |");
      Console.WriteLine("| (2) Torre da Rainha                                                           |");
      Console.WriteLine("| (3) Bispo Negro                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      Console.WriteLine();
      Console.Write("Informe a opção desejada para continuar: ");
      string option = Console.ReadLine();

      switch (option)
      {
        case "1":
          kingHorse(option);
          break;
        case "2":
          queenTower(option);
          break;
        case "3":
          blackBishop(option);
          break;
      }
    }

    //--------> OPÇÃO 1 <----------
    static void kingHorse(string option)
    {
      //corvinal++;

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                                 CAVALO DO REI                                 |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Cavalo do rei uma escolha de sorte e coragem                                 |");
      Console.WriteLine("| você se sacrificou para vencer o jogo!                                        |");
      Console.WriteLine("| Após o lance que move o cavalo para a h3                                      |");
      Console.WriteLine("| o bispo poderá se encaminhar para o xeque-mate graças a sua jogada            |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //throwDice();

      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 1 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           CAVALO DO REI  --  SUCESSO                          |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Magnífico, é preciso muita coragem e lealdade,                             |");
      Console.WriteLine("| para se sacrificar para um bem maior, você teve um jogo digno de grande mestre|");
      Console.WriteLine("| como dizia um Grande Mestre:                                                  |");
      Console.WriteLine("|      -Não há nenhum grande mestre de xadrez que seja normal, diferenciam-se   |");
      Console.WriteLine("| apenas pela magnitude da loucura.                                             |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|              Ganhou dois ponto por isso :D                                    |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
        //point+=2;    

      //if (name == "rony wesley")
        Console.WriteLine();

        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        Console.WriteLine("|                           ESTER EGG ENCONTRADO                                 |");
        Console.WriteLine("|-------------------------------------------------------------------------------|");
        Console.WriteLine("|                                                                               |");
        Console.WriteLine("|     Shazam! Por ter o mesmo nome que o corajoso Ronald Bilius Weasley,        |");
        Console.WriteLine("| você ganhou mais um ponto de vida.                                            |");
        Console.WriteLine("| Parabéns! Aqui vão 5 pontos extras por essa conquista                         |");           
        Console.WriteLine(" ------------------------------------------------------------------------------- ");
        //point+=5;
        // life++;
      // endif

      //else
      Console.WriteLine();
      Console.WriteLine("Opção 1 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           CAVALO DO REI   --  FRACASSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Lindo xeque no rei, mas não foi o suficiente, a Rainha do adversário       |");
      Console.WriteLine("| acabou com você te reduzindo a pó, está fora do jogo de xadrez!               |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|  Que pena acabou de perder um ponto e uma vida”                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

      //shift+alt 
    }

    //---------> OPÇÃO 2 <---------
    static void queenTower(string option)
    {
      //lufalufa++;

      //throwDice();
      //se success()

      Console.WriteLine();
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Torre da rainha uma escolha de garantia                                     |");
      Console.WriteLine("| você ficou observando o jogo sem correr grande perigo até o momento!          |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine();

      Console.WriteLine("Opção 2 - sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           TORRE DA RAINHA  --  SUCESSO                        |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Após o lance cavalo na h3, uma jogada de honra, sacrificando-o              |");
      Console.WriteLine("| para vencer o jogo, você se manteve no lugar,                                 |");
      Console.WriteLine("| lembrando que está em um tabuleiro e que todo o movimento conta!              |");
      Console.WriteLine("| Parabéns! Você ganhou um ponto por isso :D                                    |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point++;

      //else

      Console.WriteLine();
      Console.WriteLine("Opção 2 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                        TORRE DA RAINHA --  FRACASSO                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Vish, parece que ao ver o sacrifício do cavalo na h3,                      |");
      Console.WriteLine("| você correu até lá para ajudar, além de ter feito uma jogada em vão,          |");
      Console.WriteLine("| sniff sniff, acabou de perder um ponto e uma vida”                            |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

    }

    //---------> OPÇÃO 3 <---------
    static void blackBishop(string option)
    {
      //grifinoria++;
      //sonserina++;

      //throwDice();
      //se success()
      Console.WriteLine();
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   Bispo Negro, após o sacrificio de cavalo h3, uma jogada de honra e coragem  |");
      Console.WriteLine("|  o XEQUE MATE ficou por sua conta!                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine();
       //throwDice();

      //se success()

      Console.WriteLine();
      Console.WriteLine("Opção 1 - sucesso");

      Console.WriteLine(" -------------------------------------------------------------------------------");
      Console.WriteLine("|                                 BISPO NEGRO                                   |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Com muita sabedoria você conteve a torre da rainha no seu devido lugar,    |");
      Console.WriteLine("| e assim podendo efetuar seu lance!                                            |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| Jogue o dado novamente para tentar o xeque mate!”                             |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //throwDice();
      //receiveDice = throwDice();

      //se receiveDice for sucesso

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- sucesso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           BISPO NEGRO  --  SUCESSO                            |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Parabéns! Seu xeque mate foi magnífico, deixando seu adversário em pedaços |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|   URRUL! Bônus de 5 pontos por essa conquista,  e também um ponto de vida”    |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      //point+=5;
      //life++;


      //else

      Console.WriteLine();
      Console.WriteLine("Opção 1 - Joga dado novamente -- fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           BISPO NEGRO  --  FRACASSO                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    Ih não foi dessa vez. Você avançou o número de casas de maneira errada,    |");
      Console.WriteLine("| e foi decapitado pela rainha,  perdeu um ponto e um ponto de vida             |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point--;
      //life--;

      //else
      Console.WriteLine();
      Console.WriteLine("Opção 1 - fracasso");

      Console.WriteLine(" ------------------------------------------------------------------------------- ");
      Console.WriteLine("|                           BISPO NEGRO  --  FRACASSO                           |");
      Console.WriteLine("|-------------------------------------------------------------------------------|");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("|    “Grrr parece que a torre da rainha se movimentou na sua vez,               |");
      Console.WriteLine("| o adversário além de derrotar a torre, conseguiu se defender do xeque mate.   |");
      Console.WriteLine("|                                                                               |");
      Console.WriteLine("| menos três pontos e uma vida a menos                                          |");
      Console.WriteLine(" ------------------------------------------------------------------------------- ");

      //point-=3;;
      //life--;

      //shift+alt 
    }
}
}
  

  