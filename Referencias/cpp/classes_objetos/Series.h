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
			getline(cin,nome); // fun��o captura strings com espa�o
			cout << "Quantidade de episodios: ";
			cin >> episodios;
			setbuf(stdin,NULL); // fun��o limpar o buffer do teclado
		}
		
		// Metodo para mostrar os Atributos
	    void imprimir(){
	    	cout << "Nome da Serie: " << nome <<endl;
	    	cout << "Episodios: " << episodios << endl;
		}
};
