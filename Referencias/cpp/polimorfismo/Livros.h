#include <iostream>
using namespace std;
// A Sobrecarga de Operadores está após o final desta Classe
class Livros {
	private:
		//Atributos
		string titulo;
		string autor;
		int paginas;
		
		public:
			//Construtor Padrao
			Livros(){
				this->titulo = "not info";
				this->autor = "not info";
				this->paginas = 0;
			}
			//Construtor Parametrizado
			Livros(string titulo, string autor, int paginas){
				this->titulo = titulo;
				this->autor = autor;
				this->paginas = paginas;
			}
			
			//Metodos Setters
			void setTitulo(string titulo){
				this->titulo = titulo;
			}
			
			void setAutor(string autor){
				this->autor = autor;
			}
			
			void setPaginas(int paginas){
				this->paginas = paginas;
			}
			
			//Metodos Getters
			string getTitulo()const {
				return this->titulo;
			}
			
			string getAutor()const {
				return this->autor;
			}
			
			int getPaginas()const{
			    return this->paginas;
			}
			
			//Metodo Ler
			void ler(){
				setbuf(stdin,NULL); 
				cout << "\nInformacoes do Livro" << endl;
				cout << "Informe o Titulo: ";
				getline(cin,this->titulo);
				cout << "Informe o nome do Autor: ";
				getline(cin,this->autor);
				cout << "Quantidade de paginas: ";
				cin >> this->paginas;
			}
			
			//Metodo imprimir
			void imprimir(){
				cout << "\nObjeto Livro" << endl;
				cout << "Titulo: " << this->getTitulo() << endl;
				cout << "Autor: " << this->getAutor() << endl;
				cout << "Paginas: " << this->getPaginas() << endl;
			}
};

//SOBRECARGA DE OPERADORES

const Livros operator + (const Livros l1, const Livros l2){ // Esta função ira somar dois objetos Livros
	Livros livro;
	livro.setTitulo(l1.getTitulo() + " " + l2.getTitulo());
	livro.setAutor(l1.getAutor() + " " + l2.getAutor());
	livro.setPaginas(l1.getPaginas() + l2.getPaginas());
	return livro;
}

const bool operator > (const Livros l1, const Livros l2){ // Esta função compara qual livro tem mais paginas 
	if(l1.getPaginas() > l2.getPaginas()){
		return true; // retorna true se o primiero parametro tiver mais paginas
	}
	return false;
}

const Livros operator - (const Livros l1, int pag){ // Esta função ira subtrair um numero de paginas
	int p = l1.getPaginas() - pag;
	return Livros(l1.getTitulo(), l1.getAutor(), p);
}


