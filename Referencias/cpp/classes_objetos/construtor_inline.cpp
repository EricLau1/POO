#include <iostream>
#include "Pessoa.h"
using namespace std;

class Cadastro {
	public:
		//Atributos
		Pessoa usuario;
		string email;
		string senha;
		
		//Construtor padrao inline
		Cadastro(): email("not info"), senha("***") {} // usuario sera inicializado com o construtor padrao da classe Pessoa
		
		//Construtor parametrizado inline
		Cadastro(Pessoa pe, string em, string se):
			usuario(pe), email(em), senha(se){}
		
		void imprimir(){
			cout << "\nCadastro " << endl;
			usuario.imprimir();
			cout << "Email: " << email << endl;
			cout << "Senha: " << senha << endl;
		}
};

int main(){
	
	Cadastro c1;
	c1.imprimir();
	
	Cadastro c2(Pessoa("Laura",20), "laura@email.com", "qwe123");
	c2.imprimir();
	return 0;
}
