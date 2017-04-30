#include <iostream>
#include "Personagem.h"
using namespace std;

class Heroi: public Personagem { // sitaxe - classe Heroi herda todos os atributos e metodos de Personagem

     private:
     	string titulo;
     	int pontos;
     	
     	public:
     	
		 Heroi(){
		 	
		 	this->titulo = "Iniciante";
		 	this->forca = 0;
		 	this->agilidade = 0;
		 	this->inteligencia = 0;
		 	this->pontos = 20;
		 	this->nivel = 1;
		 }	
     	
     	Heroi(string nome,int forca, int agilidade, int inteligencia){
     		titulo = "Iniciante";
     		pontos = 20;
     		this->nome = nome;
     		this->forca = forca;
     		this->agilidade = agilidade;
     		this->inteligencia = inteligencia;
     		this->nivel = 1;
		 }
     	
     	void levelUP(string atributo, int pontos){
     		this->pontos += 5; // a cada lvlup o heroi ganha + 5 pontos
     		if(atributo == "forca"){
     			this->forca += pontos;
			 }else if(atributo == "agilidade"){
			 	this->agilidade += pontos;
			 }else if(atributo == "inteligencia"){
			 	this->inteligencia += pontos;
			 }
			 this->pontos -= pontos;
			 levelUp();	
		 }
		 
		 void imprimir(){
		 	cout << "\nTitulo: " << this->titulo << endl;
			status();
			cout << "Pontos de Habilidade: " << this->pontos << endl;
		 	
		 }
		 
		 criar(){
		 	
		 	cout << "\nCriacao de Personagem" << endl;
		 	int p;
		 	cout << "Nome: ";
		 	cin >> this->nome;
		 	cout << "Pontos(" << this->pontos << ") em Forca: ";
		 	cin >> p;
		 	setForca(p);
		 	cout << "Pontos(" << this->pontos << ") em Agilidade: ";
		 	cin >> p;
		 	setAgilidade(p);
		 	cout << "Pontos(" << this->pontos << ") em Inteligencia: ";
		 	cin >> p;
		 	setInteligencia(p);
		 }
		
		
		void setForca(int f){
			if(f <= this->pontos){
			  this->forca += f;
		      this->pontos -= f;
		   }
		}
		
		void setAgilidade(int a){
			if(a <= this->pontos){
				this->agilidade += a;
				this->pontos -= a;
			}
		}
		
		void setInteligencia(int i){
			if(i <= this->pontos){
			this->inteligencia += i;
			this->pontos -= i;
		   }
		}
	
};

