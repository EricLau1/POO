#include <iostream>
#include "Facebook.h"
using namespace std;

int main(){
	
	Facebook f1[3];
	
	f1[0].adicionar("Pato Donald");
	f1[0].comentar("Ontem a festa foi loca!!! D:");
	f1[0].curtir();
	f1[0].imprimir();
	
	f1[1].adicionar("Pluto");
	f1[1].comentar("Um tigre, dois tigres, tres tigres...");
	f1[1].curtir();
	f1[1].curtir();
	f1[1].curtir();
	f1[1].imprimir();
 	
	return 0;
}
