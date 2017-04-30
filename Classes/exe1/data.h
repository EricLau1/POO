//Data.h
#include <iostream>
#include <sstream>
using namespace std;

class Data {
	private:
		int dia;
		int mes;
		int ano;
	public:
         //Data(): dia(1), mes(1), ano(1900) { } //construtor padrão inline
       Data();  // protótipo ou assinatura
      // Data(int, int, int);
   	   Data(int dia, int mes, int ano): dia(dia), mes(mes), ano(ano) {}
   	   ~Data(); // metodo destrutor - ocorre implicitamente quando o objeto e destruído

       //gets
       int getDia() const {return this->dia;}
       int getMes() const {//mes = mes*9;
	                       return mes;}// nao necessita this, pois nao tem outra variavel com mesmo nome
       int getAno() const; // implementado fora da interface da classe

       //sets
       void setDia(int dia){this->dia = dia;}
       void setMes(int mes){this->mes = mes;}
       void setAno(int);

	   void imprimir();
	   
	   string toString(){
	   	  ostringstream objeto;
	   	  objeto << "Data\n";
	   	  objeto << this->getDia() << "/";
	   	  objeto << this->getMes() << "/";
	   	  objeto << this->getAno() << endl;
	   	  return objeto.str();
	   }
};


Data::Data(){
	dia=1;
	mes=1;
	ano=1900;
}

/*
Data::Data(int dia, int mes, int ano){
	this->dia = dia; // o atributo dia recebe o valor do argumentos dia
	this->mes = mes;
	this->ano = ano;
}*/

Data::~Data(){
	//cout << "O objeto da data abaixo foi destruido: ";
	//imprimir();
}


int Data::getAno() const{
	//ano = ano +100-789; //nao pode fazer calculos pois o metodo e constante
	return ano;
}

void Data::setAno(int ano){
	this->ano=ano;
}

void Data::imprimir(){
	cout << "\nData: " << dia << "/" << mes << "/" << ano << endl;
}




