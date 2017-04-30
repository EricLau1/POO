#include <iostream>
#include "Series.h"
using namespace std;

int main(){
	
	Series s1;
	s1.ler();
	s1.imprimir();
	
	 // forma alternativa de inicializar o objeto
	Series s2 = {"CSI", 1000}; // o atributo nome recebe a string e o atributo episodios recebe o valor inteiro
	s2.imprimir();
}
