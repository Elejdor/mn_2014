#define _CRT_SECURE_NO_WARNINGS

#include <cmath>
#include <iostream>
#include "Functions.hpp"
#include "Add1.hpp"
#include "gnuplot_i.hpp"
#include <vector>

void plot(double p, double k, Function* function)
{
	Gnuplot::set_GNUPlotPath("C:\\gnuplot\\bin");
	Gnuplot main_plot;

	main_plot.set_xlabel("x");
	main_plot.set_ylabel("y");

	main_plot.set_style("lines");
	main_plot.set_grid();

	main_plot.set_xrange(p, k);
	main_plot.plot_equation(function->toChars());

	system("pause");
}

int main()
{
	//Asserting
	Function *foo = new Logarithmic();
	bool (*stopCondition)(double, double, double) = Add1::stopValue;

	//Set max iterations
	int iters = 17;
	std::cout << "Max iterations: " << iters << "\n\n";

	//Bisection
	std::cout << "Bisection method:\n";
	double result = Add1::Bisection(foo, 0.1f, 3, iters, stopCondition);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo->dx0(result) << std::endl;

	//Newton
	std::cout << "\n\nNewton's method:\n";
	result = Add1::Newton(foo, 2.0f, iters, stopCondition, true);
	std::cout << "x = " << result << std::endl << "f(x) = " << foo->dx0(result) << std::endl;

	//Plotting
	plot(0, 5, foo);

	return 666;
}