//candidato.h
#include <iostream>
#include "partido.h"
#include "cidade.h"
#include "data.h"
using namespace std;
/*
Candidato: herda Partido
id: inteiro;
nome: string;
cidade: Cidade;
filiacao: Data;
*/

class Candidato: public Partido{
	private:
		//Atributos privados - Somente a classe tem acesso
		int id;
		string nome;
		Cidade cidade;
		Data filiacao;
	
	public: // Metodos Publicos Prototipados
		
		Candidato(); // Construtor Padrão
		Candidato(int,string,Cidade,Data); // Construtor Parametrizado
		
		//Metodos Setters - Prototipados
		
		void setId(int);
		void setNome(string);
		void setCidade(Cidade);
		void setCidade(int,string); // metodo setter usando polimorfimo *sobrecarga
		void setFiliacao(Data);
		void setFiliacao(int,int,int);// metodo setter usando polimorfimo *sobrecarga
		
		//Metodos Getters 
		int getId()const;
		string getNome()const;
		Cidade getCidade()const;
		Data getFiliacao()const;
		
		//Metodo toString()
		string toString();
		
};

//Construtores
Candidato::Candidato(){
	this->id = 0;
	this->nome = "not info";
}

Candidato::Candidato(int id,string no,Cidade ci,Data fi){
	this->id = id;
	this->nome = no;
	this->cidade = ci;
	this->filiacao = fi;
}

//Metodos Setters

void Candidato::setId(int id){
	this->id = id;
}

void Candidato::setNome(string no){
	this->nome = no;
}

void Candidato::setCidade(Cidade ci){
	this->cidade = ci;
}

void Candidato::setCidade(int id,string no){
	this->cidade.setId(id);
	this->cidade.setNomeCid(no);
}

void Candidato::setFiliacao(Data fi){
	this->filiacao = fi;
}

void Candidato::setFiliacao(int dia,int mes,int ano){
	this->filiacao = Data(dia,mes,ano);
}

//Metodos Getters

int Candidato::getId()const{
    return this->id;
}

string Candidato::getNome()const{
	return this->nome;
}

Cidade Candidato::getCidade()const{
	return this->cidade;
}

Data Candidato::getFiliacao()const{
    return this->filiacao;
}

//Metodo toString()

string Candidato::toString(){
	ostringstream objeto;
	objeto << "Classe Candidato\n";
	objeto << "ID: " << this->getId() << endl;
	objeto << "Nome: " << this->getNome() << endl;
	objeto << "Cidade: " << this->getCidade().toString() << endl; 
	objeto << "Filiacao: " << this->getFiliacao().toString() << endl;
	return objeto.str(); 
}
