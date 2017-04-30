//partido.h
#include <iostream>
#include <sstream>
using namespace std;
/* 
Partido
sigla: string;
descricao: string;
*/

class Partido{
	
	protected:
		string sigla;
		string descricao;
		
    public: // Metodos publicos prototipados
        
        Partido(); // Construtor Padrão
        Partido(string,string); // Construtor Parametrizado
        
        // Metodos Setters
        void setSigla(string);
        void setDescricao(string);
        
        //Metodos Getters
        string getSigla()const;
        string getDescricao()const;
        
        //Função toString() returna os valores do objeto
        string toString();
        
};

//Construtores
Partido::Partido(){
	this->sigla = "not info";
	this->descricao = "not info";
}

Partido::Partido(string si, string desc){
	this->sigla = si;
	this->descricao = desc;
}

//Metodos Setters
void Partido::setSigla(string si){
	this->sigla = si;
}

void Partido::setDescricao(string desc){
	this->descricao = desc;
}

//Metodos Getters

string Partido::getSigla()const{
	return this->sigla;
}

string Partido::getDescricao()const{
	return this->descricao;
}

//Metodo toString()

string Partido::toString(){
	ostringstream objeto;
	objeto << "Classe Partido\n";
	objeto << "Sigla: " << this->getSigla() << endl;
	objeto << "Descricao: " << this->getDescricao() << endl;
	return objeto.str();
}
