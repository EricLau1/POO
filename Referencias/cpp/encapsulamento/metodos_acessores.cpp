#include <iostream>
#include "Frankenstein.h"
#include <time.h>
using namespace std;

int main(){
	srand(time(NULL));
	Frankenstein monstro("Boo",3,7,3.5,true);
	monstro.imprimir();
	
	Frankenstein monstro2;
	monstro2.ler();
	monstro2.imprimir();	
  
    cout << "\nFazendo o experimento..." << endl;
	Frankenstein m3;
	m3.choqueEletrico();
	m3.choqueEletrico();
	m3.choqueEletrico();
	m3.choqueEletrico();
	m3.imprimir();
	
	
	return 0;
}
