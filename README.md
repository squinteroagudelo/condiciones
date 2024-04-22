Proceso triangulo
	Definir a, b, c Como Real;
	
	Escribir "Ingrese el primer lado del triángulo: ";
	Leer a;
	Escribir "Ingrese el segundo lado del triángulo: ";
	Leer b;
	Escribir "Ingrese el tercer lado del triángulo: ";;
	Leer c;
	
	Si a > 0 & b > 0 & c > 0 Entonces
		Si a == b & a == c Entonces
			Escribir "Triángulo equilatero";
		SiNo
			Si a == b | a == c | b == c Entonces
				Escribir "Triángulo isóceles";
			SiNo
				Escribir "Triángulo escaleno";
			FinSi
		FinSi
	SiNo
		Escribir "Algunos de los datos ingresados son incorrectos";
	FinSi	
FinProceso
