//estado.h
/* 

Estado
uf: string;
nomeEst: string;

*/
#include <iostream>
#include <sstream>

using namespace std;

class Estado {
   
   protected:
      string uf;
	  string nomeEst;
	  
   public:
   	  
	  Estado(); // Construtor padrão
   	  Estado(string,string); // Construtor parametrizado
   	  
   	  //Metodos setters
   	  void setUf(string);
   	  void setNomeEst(string);
   	  
   	  //Metodos getters
   	  string getUf()const;
   	  string getNomeEst()const;
   	  
   	  //Metodo imprimir
		string toString(){
			ostringstream objeto;
			objeto << "Classe Estado\n";
			objeto << "UF: " << this->getUf() << endl;
			objeto << "Nome: " << this->getNomeEst() << endl;
			return objeto.str();
		}
};

//Construtores
Estado::Estado(){
	this->uf = "not info";
	this->nomeEst = "not info";
}

Estado::Estado(string uf, string noEst){
	this->uf = uf;
	this->nomeEst = noEst;
}

//Metodos Setters

void Estado::setUf(string uf){
	this->uf = uf;
}

void Estado::setNomeEst(string noEst){
	this->nomeEst = noEst;
}

//Metodos Getters

string Estado::getUf()const{
    return this->uf;
}

string Estado::getNomeEst()const{
	return this->nomeEst;
}
