#include <iostream>
#include "Musica.h"
using namespace std;

int main(){
	
	Musica m1; 
	m1.imprimir();
	
	Musica m2("Rehab", "Back to Black",Pessoa("Amy Winehouse", 22));
	m2.imprimir();
	
	Musica m3;
	m3.ler();
	m3.imprimir();
	return 0;
}
