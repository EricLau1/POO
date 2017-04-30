#include <iostream>
#include "VideoGame.h" // importanto a classe que está na mesma pasta
using namespace std;

int main(){
	
	VideoGame game1; // game1 é um objeto da classe VideoGame e pode acessar todos os membros da classe
	
	game1.nome = "Counter Strike";
	game1.lancamento = 1997; // apenas exemplo
	
	cout << "Nome do jogo: " << game1.nome << endl;
	cout << "Lancamento: " << game1.lancamento << endl;
	game1.jogar();
	
	return 0;
}
