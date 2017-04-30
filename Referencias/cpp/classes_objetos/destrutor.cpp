#include <iostream>
using namespace std;
// O destrutor serve para desocupar a memoria de objetos que não precisam mais ser utilizados
class Vida {
	public:
		string nome;
		bool coracao;
		
		Vida(){
			nome = "not info";
			coracao = true;
		}
		
		~Vida(){ // Destrutor
			coracao = false;
			cout << nome << " foi destruido" << endl;
		}
		
		
};

int main(){
	
	Vida objeto;
	objeto.nome = "objeto1";

	return 0; 
}

