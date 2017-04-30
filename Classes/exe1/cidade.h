//cidade.h

#include <iostream>
#include <sstream>
#include "estado.h"
using namespace std;

/*
Cidade: herda Estado
id: inteiro;
nomeCid: string;
*/

class Cidade: public Estado{
   
   private:
      int id;
	  string nomeCid;
   
   public: // *Metodos Publicos prototipados
   	
      Cidade(); // Construtor Padrão - 
	  Cidade(int,string); //Construtor Parametrizado
	  
	  //Metodos Setters
	  void setId(int);
	  void setNomeCid(string);
	  
	  //Metodos Getters
	  int getId()const;
	  string getNomeCid()const;
	  
	  //Função toString() retorna os valores do objeto
	  string toString();
};

//Construtores
Cidade::Cidade(){
	this->id = 0;
	this->nomeCid = "not info";
}

Cidade::Cidade(int id,string cidade){
	this->id = id;
	this->nomeCid = cidade;
}

//Metodos Setters

void Cidade::setId(int id){
	this->id = id;
}

void Cidade::setNomeCid(string ci){
	this->nomeCid = ci;
}

//Metodos Getters

int Cidade::getId()const{
	return this->id;
}

string Cidade::getNomeCid()const{
	return this->nomeCid;
}

string Cidade::toString(){
	ostringstream objeto;
	objeto << "Classe Cidade\n";
	objeto << "ID: " << this->getId() << endl;
	objeto << "Nome: " << this->getNomeCid() << endl;
	return objeto.str();
}
