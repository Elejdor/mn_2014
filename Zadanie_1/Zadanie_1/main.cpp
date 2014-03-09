#include <cmath>
#include <iostream>

#include "Add1.hpp"

double foo(double x)
{
	return x*x-100;
}

double fooDX(double x)
{
	return 2 * x;
}

int main()
{
#define zadanie_1
#ifdef zadanie_1

	int n = 50;
	std::cout << "Max iterations: " << n << "\n\n";

	std::cout << "Bisection method:\n";
	double result = Add1::Bisection(foo, 1, 11, n, Add1::stopCond);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo(result) << std::endl;

	std::cout << "\n\nNewton's method:\n";
	result = Add1::Newton(foo, fooDX, 1, n, Add1::stopCond);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo(result) << std::endl;
#endif

	system("pause");
	return 0;
}