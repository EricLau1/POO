#include <iostream>
using namespace std;
// Uma classe é tipo de dado que contem Atributos/Variaveis e Métodos/Funções

class VideoGame {
	public:
		//Atributos
		string nome;
		int lancamento;
	
	//Método
	void jogar(){
		cout << nome << " iniciando..." << endl;
	}	
		
};
