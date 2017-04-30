#include <iostream>
#include "Login.h"
using namespace std;

int main(){
	
	Login usuario1;
	usuario1.imprimir();
	
	Login usuario2(10,"Dipper","dipper@email.com","asdas654");
	usuario2.imprimir();
	return 0;
}
