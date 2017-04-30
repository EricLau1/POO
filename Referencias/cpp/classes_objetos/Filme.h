#include <iostream>
using namespace std;

class Filme {
	public:
		//Atributos
		string nome;
		string genero;
		int duracao;
		
		//Um construtor inicializa os atributos quando um objeto é criado
		// um construtor nao retorna nenhum tipo e tem o nome IDENTICO ao da Classe
		
		Filme(){ // Construtor padrão que não recebe parametros 
			nome = "not info";
			genero = "not info";
			duracao = 0;
		}
		
		Filme(string no, string ge, int du){ // Construtor que recebe parametros
			nome = no;
			genero = ge;
			duracao = du;
		}
		
		void imprimir(){
			cout << "\nClasse Filme " << endl;
			cout << "Nome do filme: " << nome << endl;
			cout << "Genero: " << genero << endl;
			cout << "Duracao: " << duracao << " minutos " << endl;
		}
		
};
