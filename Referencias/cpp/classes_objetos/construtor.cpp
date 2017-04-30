#include <iostream>
#include "Filme.h"
using namespace std;

int main(){
	
	Filme f1; // este objeto chama o constutor padrao automaticamento pois nao passa nenhum parametro
	
	f1.imprimir();
	
	Filme f2("Exorcista", "Terror",120); // este objeto chama o construtor que recebe parametros
	
	f2.imprimir();
	 
	return 0;
}
