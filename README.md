# Game_BatalhaNaval
Jogo desenvolvido em C# Console e Visualg (Português Estruturado)

* Desenvolvedores: Caio de Oliveira Silva e Jefferson Bispo da Silva 



* ESTUDO DE CASO 

O batalha naval que desenvolvemos funciona da seguinte maneira:
O jogador deve determinar um valor para linha e para coluna no tabuleiro 11x11.
Por exemplo: linha 2, coluna 1. Esse valor provavel que dê "Splash".
Como assim "Splash"? Determinamos isso para quando o jogador escolher 
o espaço errado e "cair" na água (Como no Batalha Naval tradicional).
 Se errar, continue a procurar todos os elementos.

E determinamos mais 4 tipos de elementos que são: 

O Navio;

A Boia;

O Destroier; 

O Submarino;

Lembrando que os valores são aleatórios aonde estão os elementos do jogo.
Se o jogador quiser desistir, basta pressionar 'Esc' duas vezes.
Boa sorte para encontrar eles dentro do tabuleiro!



* MAPA 

11x11;

O mapa não fica explicito na tela, pois decidimos fazer com respostas somente.



* CÓDIGO EM VISUALG (PORTUGUÊS ESTRUTURADO) 

```
Var
  M: Vetor[1..10,1..10] de Caracter
  col, lin, navio, boia, destroier, submarino, JogaLinha, JogaColuna: inteiro;
  AcabarJogo: Logico;


Inicio

escreval("                  Batalha Naval              ")
escreval("")
escreval("")
escreval("  Encontre Navios, Boias, Submarinos, Destroier  ")
escreval("")
escreval("")
escreval("    PARA DESISTIR: Pressione duas vez o 'ESC'     ")
escreval("")
escreval("")

   para lin de 1 ate 10 faca
      para col de 1 ate 10 faca
         M[lin,col] := "A"
      fimpara
   fimpara

para navio de 1 ate 4 faca
  lin := randi(10)
  col := randi(10)

  se lin = 0 entao
     lin:= lin + 1
  fimse

  se col = 0 entao
     col:= col + 1
  fimse

  M[lin,col]:="N"
fimpara

para boia de 1 ate 4 faca
  lin := randi(10)
  col := randi(10)

  se lin = 0 entao
     lin:= lin + 1
  fimse

  se col = 0 entao
     col:= col + 1
  fimse

  M[lin,col]:="B"
fimpara

para submarino de 1 ate 2 faca
  lin := randi(10)
  col := randi(10)

   se lin = 0 entao
     lin:= lin + 1
  fimse

  se col = 0 entao
     col:= col + 1
  fimse

  M[lin,col]:="S"
fimpara


para destroier de 1 ate 2 faca
  lin := randi(10)
  col := randi(10)

  se lin = 0 entao
     lin:= lin + 1
  fimse

  se col = 0 entao
     col:= col + 1
  fimse

  M[lin,col]:="D"
fimpara



escreval("")
escreval("             QUE COMECE A BATALHA!!!            ")

AcabarJogo:=falso;

enquanto  nao(AcabarJogo) faca
  escreval("")
  escreval("     Digite o valor de uma linha (1-10): ")
  leia(JogaLinha)
   Escreval
  escreval("     Digite o valor de uma coluna (1-10): ")
  leia(JogaColuna)

se ((JogaLinha = 0) E (JogaColuna = 0)) entao
     AcabarJogo:= verdadeiro;
  senao
 se((JogaLinha>=1) E (JogaLinha<=10) E (JogaColuna>=1) E (JogaColuna<=10)) entao
       Escreval
     se  M[JogaLinha,JogaColuna] = "A" entao
       escreval("              Splash              ")
     fimse
       Escreval("")
     se M[JogaLinha,JogaColuna] = "N" entao
         escreval("            Navio              ")
     fimse
       Escreval("")
     se M[JogaLinha,JogaColuna] = "B" entao
           escreval("          Boia              ")
     fimse
       Escreval("")
     se M[JogaLinha,JogaColuna] = "D" entao
        escreval("             Destroier            ")
     fimse
       Escreval("")
     se M[JogaLinha,JogaColuna] = "S" entao
         escreval("            Submarino            ")
     fimse
       Escreval("")
     M[JogaLinha,JogaColuna]:= "J"

  fimse
 fimse
fimenquanto

Fimalgoritmo
