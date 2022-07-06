using System;

int main()
{
	float distancia;
	int tiempo;
	float velocidad;
	cout << "ingrese la velocidad en m/s";
	cin >> velocidad;
	cout << "ingrese tiempo por segundos";
	cin >> tiempo;
	// Proceso 
	distancia = velocidad * tiempo;
	// informar
	cout << "el auto alcanzo la distancia a velocidad" << velocidad << "en" << tiempo << "seg es de" << distancia << endl;
	return 0;
}

