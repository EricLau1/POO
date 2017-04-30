#include <iostream>
using namespace std;

class Series {
	public:
		// Atributos
		string nome;
		int episodios;
		
		// Metodo para ler os Atributos
		void ler(){
			cout << "Informe o nome da Serie: ";
			getline(cin,nome); // função captura strings com espaço
			cout << "Quantidade de episodios: ";
			cin >> episodios;
			setbuf(stdin,NULL); // função limpar o buffer do teclado
		}
		
		// Metodo para mostrar os Atributos
	    void imprimir(){
	    	cout << "Nome da Serie: " << nome <<endl;
	    	cout << "Episodios: " << episodios << endl;
		}
};
