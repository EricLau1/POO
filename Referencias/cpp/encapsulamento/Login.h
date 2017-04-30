#include <iostream>
using namespace std;

class Login{
	private:
		//Atributos privados somente a classe tem acesso
		int identificacao;
		string usuario;
		string email;
		string senha;
		
		public:
			// Com os metodos publicos será possivel acessar os atributos privados
			Login(){
				identificacao = 0;
				usuario = "not info";
				email = "not info";
				senha = "not info";
			}
			
			Login(int id,string user,string em,string se){
				identificacao = id;
				usuario = user;
				email = em;
				senha = se;
			}
			
			void imprimir(){
				cout << "\nLogin" << endl;
				cout << "ID: " << identificacao << endl;
				cout << "Nome : " << usuario << endl;
				cout << "Email: " << email << endl;
				cout << "Senha: " << senha << endl;
 			}
 			
};
