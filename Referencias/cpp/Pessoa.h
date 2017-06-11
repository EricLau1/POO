#include <iostream>
using namespace std;
class Pessoa{
	private:
	int id;
	string nome;
	float altura;

	public:
	Pessoa(){
	id = 0;
	nome = "";
	altura = 0;
	}

	Pessoa(int arg1,string arg2,float arg3){
	id = arg1;
	nome = arg2;
	altura = arg3;
	}

	void setId(int arg1){
	this->id = arg1;
	}

	void setNome(string arg2){
	this->nome = arg2;
	}

	void setAltura(float arg3){
	this->altura = arg3;
	}

	int getId()const{
	 return this->id;
	}

	string getNome()const{
	 return this->nome;
	}

	float getAltura()const{
	 return this->altura;
	}

};