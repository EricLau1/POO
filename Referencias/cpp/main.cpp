#include <iostream>
#include <fstream>
#include <string.h>
#include <conio.h>

//Este algoritmo cria uma Classe padrao POO:
// atributos privados
// metodos publicos
// construtores padrao e parametrizado
// metodos getters e setters
// aceita somente os tipos string, float, int e double
// nao esta programada para lidar com ponteiro ou atributos agregados de outras classes

using namespace std;

struct Classe {
	char nome[16];
	string tipo[100];
	string atributo[100];	
}classe;

int main(){
	setlocale(LC_ALL, "Portuguese");
	
	cout << "Informe o nome da classe sem espaços: ";
	cin >> classe.nome;
	char aux[100];
	strcpy(aux,classe.nome);
    strcat(classe.nome,".h");
    
    int quantidade;
    for(int i = 0; i < 100; i++){
    	cout << "Informe o TIPO " << (i + 1) << "º atributo: ";
    	cin >> classe.tipo[i];
    	cout << "Informe o NOME do " << (i + 1) << "º atributo: ";
    	cin >> classe.atributo[i];
    	quantidade++;
    	cout << "Deseja continuar? <S>Sim <N>Não ";
    	char r = getche();
    	if(r == 'S' || r == 's'){
    	  cout << endl;	
		}else{
			break;
		}
	}
    
	const char* c = classe.nome;	
	
	ofstream out(c);
	
	out << "#include <iostream>\n";
	out << "using namespace std;\n";
	out << "class " << aux << "{\n";
	out << "\tprivate:\n";
	
	
	//escrevendo os atributos
	for(int i = 0; i < quantidade; i++){
		out << "\t"<< classe.tipo[i] << " " << classe.atributo[i] << ";" << endl;
	}
	
	//escrevendo os construtores
	out << "\n\tpublic:\n";
	out << "\t" << aux << "(){\n";
	for(int i = 0; i < quantidade; i++){ // Construtor padrao
		if(classe.tipo[i] == "string"){
			out << "\t" << classe.atributo[i] << " = \"\";" << endl; 
		}else{
			out << "\t"<< classe.atributo[i] << " = 0;" << endl;
		}
	}
	out << "\t}\n\n";
	
	//Construtor parametrizado
	string v[10] = {"arg1","arg2","arg3","arg4","arg5","arg6","arg7", "arg8", "arg9","arg10"};
	out <<"\t" << aux << "(";
	for(int i = 0; i < quantidade; i++){
		out << classe.tipo[i] << " " << v[i];
		if(i < quantidade - 1){
			out << ",";
		}
	}
	out << "){\n";
	for(int i = 0; i < quantidade; i++){
	    out << "\t" << classe.atributo[i] << " = " << v[i] << ";" << endl;
	}
	
	out << "\t}\n\n";
	
	//Escrevendo metodos setters
	for(int i = 0; i < quantidade; i++){
		string texto = classe.atributo[i];
		texto[0] = toupper(texto[0]); // toupper() transforma um caractere minusculo e maiusculo
		
		out << "\tvoid " << "set" << texto << "(";
		out << classe.tipo[i] << " " << v[i] << "){\n";
		out << "\tthis->" << classe.atributo[i] << " = " << v[i] << ";\n";
		out << "\t}\n\n";
	}
	
	//Escrevendo metodos getters
	for(int i = 0; i < quantidade; i++){
		string texto = classe.atributo[i];
		texto[0] = toupper(texto[0]);
		
		out << "\t" << classe.tipo[i] << " " << "get" << texto << "()const{\n";
		out << "\t return this->" << classe.atributo[i] << ";\n";
		out << "\t}\n\n";
	}
	
	out << "};";
	
	cout << "\n\nUm documento " << c << " foi criado nesta pasta." << endl;
	getch();
	system("cls");
	cout << "Author: fabricadealgoritmos@gmail.com";
	
		
	return 0;
}

