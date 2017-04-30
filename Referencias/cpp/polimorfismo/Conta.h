#include <iostream>
using namespace std;

class Conta {
	public:
		int id;
		string nome;
		float saldo;
		
		Conta(): id(0), nome("not info"), saldo(0){}
		
		//Polimorfismo de sobrecarga:
		//Assinatura do método são o nome, quatidade de parametros e seus tipos
		//Sobrecarga significa que metodos poderão ter nomes iguais
		//porém a quantidade de parametros ou seus tipo serão obrigatoriamente diferentes
		//metodos com a mesma assinatura não serão compilados.
		
		void sacar(){
			if(this->saldo >= 100){
			this->saldo = this->saldo - 100; // este metodo saca 100 reais por padrao
             cout << "100,00 R$ foram sacados" << endl; 
		   }
		}
		
		void sacar(float valor){
			if(valor <= this->saldo) {
			this->saldo = this->saldo - valor; // este metodo saca o valor que o usuario quer
		     cout << valor << " R$ foram sacados" << endl;
		   }
		}
		
		//o metodo abaixo recebe um valor R$ e um valor de porcentagem
		void sacar(float valor,float p){
			p /= 100; // transforma p em porcentagem
			p *= this->saldo; // p agora é a porcentagem do saldo
			if(valor <= this->saldo) {
			  this->saldo = this->saldo - valor;
			  this->saldo = this->saldo - p;
			  cout << valor << " R$ foram sacados " << endl;
			  cout << p << " R$ foi descontado do saldo" << endl;
		    }
			// Neste metodo uma porcentagem e descontada cada vez que o dinheiro e sacado
		}
		
		void imprimir(){
			cout << "\nConta " << endl;
			cout << "ID: " << this->id << endl;
			cout << "Nome: " << this->nome << endl;
			cout << "Saldo: " << this->saldo << endl;
		}
		
	
};

