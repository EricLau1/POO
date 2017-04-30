#include <iostream>
using namespace std;

class Pessoa {
	public:
		string nome;
		int idade;
		
		//Construtor padrão
		Pessoa(){
			nome = "not info";
			idade = 0;
		}
		
		//Construtor parametrizado
		Pessoa(string no, int id){
			nome = no;
			idade = id;
		}
		
		void imprimir(){
			cout << "Nome: " << nome << "\nIdade: " << idade << " anos " << endl;
		}
		
		void ler(){
			setbuf(stdin,NULL);
			cout << "Informe seu nome: ";
			getline(cin,nome);
			cout << "Informe sua idade: ";
			cin >> idade;
			setbuf(stdin,NULL);
		}
};
