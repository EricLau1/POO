//main
#include <iostream>
#include "candidato.h"
using namespace std;
int main(){
	
	Estado e1;
	Estado e2("SP","Sao Paulo");
	Estado e3 = Estado("MG","Minas Gerais");
	
	cout << e1.toString() << endl;
	cout << e2.toString() << endl;
	cout << e3.toString() << endl;
	
	//--------------------------------//
	
	Cidade c1;
	Cidade c2(1,"Candido Mota");
	Cidade c3 = Cidade(2,"Assis");
	
	cout << c1.toString() << endl;
	cout << c2.toString() << endl;
	cout << c3.toString() << endl;
	
	//-------------------------------//
	
	Partido p1;
	Partido p2("EPC", "Enrola pra caralho");
	Partido p3 = Partido("LPFEO","Luta pelos fracos e oprimidos");
	
	cout << p1.toString() << endl;
	cout << p2.toString() << endl;
	cout << p3.toString() << endl;
	
	//----------------------------------//
	
	Candidato ca1;
	Candidato ca2(10,"Jack Bauer",Cidade(25,"New York"),Data(25,10,1991));
	Candidato ca3 = Candidato(100,"Mae Joana",Cidade(99,"Casa Velha"),Data(1,1,1681));
	
	cout << ca1.toString() << endl;
	cout << ca2.toString() << endl;
	cout << ca3.toString() << endl;
	
	Candidato ca4;
	ca4.setCidade(36,"Triangulo das Bermudas");
	ca4.setFiliacao(6,6,1666);
	cout << ca4.toString() << endl;
	return 0;
}

