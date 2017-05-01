#include <iostream>
#include "Livros.h"
using namespace std;

int main(){
	
	Livros livro1("Harry Potter","J.K Rowlling", 500);
	Livros livro2("O Hobbit", "JRR Tolkien", 380);
	Livros livro3;
	
	livro1.imprimir();
	livro2.imprimir();
	
	livro3 = livro1 + livro2;
	cout << "\nSoma de dois livros: ";
	livro3.imprimir();
	
	cout << "\nLivro com mais paginas:";
	Livros maior;
	if(livro1 > livro2){
       maior = livro1;
	}else{
		maior = livro2;
	}
	maior.imprimir();
	
	cout << "\nQuantidade de Paginas que faltam para ler do livro1: ";
	livro1 = livro1 - 100;
	cout << livro1.getPaginas() << endl;
	
	return 0;
}
