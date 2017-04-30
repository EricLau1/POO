#include <iostream>
#include <conio.h>
#include <stdlib.h>
using namespace std;

class Frankenstein {
	private:
		string nome;
		int olhos;
	    int membros;
		float altura;
		bool vivo;
		
		public:
			Frankenstein();
			Frankenstein(string,int,int,float,bool);
			
			void ler();
			void imprimir();
			void choqueEletrico();
			
			//Metodos setters - Manipula os atributos mas não retorna valores
			void setNome(string);
			void setOlhos(int);
			void setMembros(int);
			void setAltura(float);
			void setVivo(bool);
			
			//Metodos getters - Não manipula atributos, mas retorna seus valores
			string  getNome()const; // const impede que os atributos seja modificados dentro do metodo
			int getOlhos()const;
			int getMembros()const;
			float getAltura()const;
			bool getVivo()const; 
};

//This->Atributo  é para diferenciar o nome dos atributos e dos parametros caso os mesmos sejam iguais

Frankenstein::Frankenstein(){
	this->nome = "not info";
	this->olhos = 0;
    this->membros = 0;
	this->altura = 0.0;
	this->vivo = false;
}

Frankenstein::Frankenstein(string nome, int olhos, int membros,float altura, bool vivo){
	this->nome = nome;
	this->olhos = olhos;
	this->membros = membros;
	this->altura = altura;
	this->vivo = vivo;
}

void Frankenstein::ler(){
	cout << "\nA Criatura está sendo criada..." << endl;
	cout << "Quantidade de olhos: ";
	cin >> this->olhos;
	cout << "Quantidade de membros: ";
	cin >> this->membros;
	cout << "Altura: ";
	cin >> this->altura;
	cout << "Qual sera o seu nome: ";
	cin >> this->nome;
	char resp;
	cout << "Ela esta viva? <S>Sim <N>Nao";
	resp = getche();
	fflush(stdin); // limpa o buffer do teclado
	if (resp == 'S' || resp == 's')
	   this->setVivo(true);
	else
	   this->setAltura(false);
}

void Frankenstein::imprimir(){
	cout << "\nO monstro se chama..." << this->getNome() << endl;
	cout << "possui " << this->getOlhos() << " olhos";
	cout << " e " << this->getMembros() << " membros," << endl;
	cout << "tem aproximadamente " << this->getAltura() << " metros de altura" << endl;
	cout << "e esta...";
	if(this->getVivo())
	 cout << "mexendo!!!" << endl;
	 else
	 cout << "mortinha, eu acho..." << endl;
}

//Setters

void Frankenstein::setNome(string nome){
	this->nome = nome;
}

void Frankenstein::setOlhos(int olhos){
	this->olhos = olhos;
}

void Frankenstein::setMembros(int membros){
	this->membros = membros;
}

void Frankenstein::setAltura(float altura){
	this->altura = altura;
}

void Frankenstein::setVivo(bool vivo){
	this->vivo = vivo;
}

//Getters

string Frankenstein::getNome()const{
	return this->nome;
}

int Frankenstein::getOlhos()const{
	return this->olhos;
}

int Frankenstein::getMembros()const{
	return this->membros;
}

float Frankenstein::getAltura()const {
	return this->altura;
}

bool Frankenstein::getVivo()const {
	return this->vivo;
}

void Frankenstein::choqueEletrico(){

	int num = rand()%10;
	if(num % 2 == 0) {
	  this->setVivo(true);
	  cout << "A criatura esta viva!" << endl;
     }
	 else{
	  this->setAltura(false);
	  cout << "A criatura esta morta!" << endl;
     }
}
