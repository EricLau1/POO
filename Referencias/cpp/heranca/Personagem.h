#include <iostream>
using namespace std;

class Personagem {
	protected: // atributos protected somente a classe e as filhas destas classes terao acesso aos atributos
		string nome;
		int forca;
		int agilidade;
		int inteligencia;
		int nivel;
		
		Pergonagem(){
			this->nome = "not info";
			this->forca = 0;
			this->agilidade = 0;
			this->inteligencia = 0;
			this->nivel = 0;
		}
		
		void status(){
			cout << "Nome: " << nome << endl;
			cout << "Forca: " << forca << endl;
			cout << "Agilidade: " << agilidade << endl;
			cout << "Inteligencia: " << inteligencia << endl;
			cout << "Nivel: " << nivel << endl;
		}
		
		void levelUp(){
			nivel++;
		}
	
};
