#include <iostream>
#include "Pessoa.h"
using namespace std;

class Musica {
	public:
		//Atributos
		string nome;
		string album;
		Pessoa cantor; // atributo da classe Pessoa
		
		//Construtor padrao
		Musica(){
			nome = "not info";
			album = "not info";
		    //cantor sera inicializado altomaticamento com o construtor padrao da Classe Pessoa
		}
		
		//Construtor que recebe Parametros
		Musica(string no, string alb, Pessoa ca){
			nome = no;
			album = alb;
			cantor = ca;
		}
		
		void imprimir(){
			cout << "\nClasse Musica" << endl;
			cout << "Nome da Musica: " << nome << endl;
			cout << "Nome do Album: " << album << endl;
			cout << "Cantor(a): " << cantor.nome << endl;
			//cantor.imprimir(); // chama o metodo imprimir da classe cantor que mostra seus atributos
		}
		
		void ler(){
			cout << "\nInforme o nome da musica: ";
			getline(cin,nome);
			cout << "Informe o nome do Album: ";
			getline(cin,album);
			cout << "Informe o nome do(a) Cantor(a): ";
			getline(cin,cantor.nome);
		}
};
