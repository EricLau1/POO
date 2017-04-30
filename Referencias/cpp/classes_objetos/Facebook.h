#include <iostream>
using namespace std;

class Facebook {
	public:
		//Atributos
		string amigo;
		string comentario;
		int curtidas;
		
		Facebook(); // prototipo do construtor padrao
		Facebook(string,string,int); // prototipo do construtor parametrizado
		
		// Prototipos dos metodos
		void curtir();
		void adicionar(string);
		void comentar(string);
		
		// Prototipo do metodo imprimir
		void imprimir(){
			cout << "Nome: " << amigo << endl;
			cout << "Comentario: " << comentario << endl;
			cout << "Curtidas: " << curtidas << endl;
		}
		
};

// Com os metodos prototipados dentro da Classe é possivel cria-los fora dela

//Construtores
Facebook::Facebook(){
	amigo = "not info";
	comentario = "not info";
	curtidas = 0;
}

Facebook::Facebook(string am,string co,int like){
	amigo = am;
	comentario = co;
	curtidas = like;
}

//Metodos
void Facebook::curtir(){
	curtidas++;
}

void Facebook::adicionar(string nome){
	amigo = nome;
}

void Facebook::comentar(string com){
	comentario = com;
}
