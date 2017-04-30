#include <iostream>
#include "Heroi.h"
using namespace std;

int main(){
	
	Heroi h1("Montanha",10,10,10);
	
	h1.imprimir();
	h1.levelUP("forca",10);
	h1.imprimir();
	
	Heroi h2;
	h2.imprimir();
	h2.criar();
	h2.imprimir();
	
	
	
	return 0;
}
