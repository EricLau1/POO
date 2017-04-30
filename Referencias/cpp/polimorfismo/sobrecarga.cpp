#include <iostream>
#include "Conta.h"
using namespace std;

int main(){
	
	Conta c1;
	c1.nome = "Logan";
	c1.saldo = 1000;
	c1.imprimir();
	
	c1.sacar(); // metodo saca apenas 100 reais
	c1.imprimir();
	
	c1.sacar(500); // metodo saca o valor passado como argumento
	c1.imprimir();
	
	c1.sacar(150,10); // metodo saca o valor passado como argumento e desconta uma porcentagem
	c1.imprimir();
		
	return 0;
}
