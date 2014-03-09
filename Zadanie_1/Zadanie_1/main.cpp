#include <cmath>
#include <iostream>
#include "Functions.hpp"
#include "Add1.hpp"


double fooDX(double x)
{
	return 2 * x;
}

int main()
{
#define zadanie_1
#ifdef zadanie_1
	Function *foo = new Logarithmic();

	int n = 17;
	std::cout << "Max iterations: " << n << "\n\n";

	std::cout << "Bisection method:\n";
	double result = Add1::Bisection(foo, 0.1f, 10, n, Add1::stopCond);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo->dx0(result) << std::endl;

	std::cout << "\n\nNewton's method:\n";
	result = Add1::Newton(foo, 0.1f, n, Add1::stopCond);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo->dx0(result) << std::endl;
#endif
	std::cout << std::endl;
	system("pause");
	return 0;
}