#include <cstdio>
#include <cmath>
#include "Functions.hpp"

#define EPSL 0.0001
#define EPS0 0.00001

class Add1 {
public:

	static bool stopValue(double a, double b, double result)
	{
		if (abs(result) < EPS0)
		{
			return true;
		}
			
		return false;
	}

	static bool stopRange(double a, double b, double result)
	{
		if (abs(b - a) < EPSL)
		{
			return true;
		}

		return false;
	}

	static double Newton(Function *function, double x0, int n, bool (stopCondition)(double, double, double))
	{
		double x1 = x0;
		x0 = x0 - (double)function->dx0(x0) / function->dx1(x0);

		double result = 0;

		if (n != 0 && !stopCondition(x0, x1, function->dx0(x0)))
		{
			result = Newton(function, x0, n - 1, stopCondition);
		}
		else
		{
			result = x0;
			std::cout << n << " iterations left\n";

			if (!stopCondition(x0, x1, function->dx0(x0)))
			{
				std::cout << "The result doesn't meet the required deviation (eps).\n";
			}
			else
			{
				std::cout << "Value condition hit" << std::endl;
			}
		}

		return result;
	}

	static double Newton(Function *function, double x0, int n, bool (stopCondition)(double, double, double), bool extremum)
	{
		double result = 0;
		if (!extremum)
		{
			result = Newton(function, x0, n, stopCondition);
		}
		else
		{
			double x1 = x0;
			x0 = x0 - (double)function->dx1(x0) / function->dx2(x0);

			if (n != 0 && !stopCondition(x0, x1, function->dx1(x0)))
			{
				result = Newton(function, x0, n - 1, stopCondition);
			}
			else
			{
				result = x0;
				std::cout << n << " iterations left\n";

				if (!stopCondition(x0, x1, function->dx1(x0)))
				{
					std::cout << "The result doesn't meet the required deviation (eps).\n";
				}
				else
				{
					std::cout << "Value condition hit" << std::endl;
				}
			}
		}


		return result;
	}

	static double Bisection(Function *function, double a, double b, int n, bool (stopCondition)(double, double, double))
	{
		double fooA = function->dx0(a);
		double fooB = function->dx0(b);

		double result = 0;
		double middle = (a + b) / 2;

		if (fooA*fooB < 0 && n != 0 && !stopCondition(a, b, function->dx0(middle)))
		{
			if (fooA * function->dx0(middle) < 0)
			{
				result = Bisection(function, a, middle, n - 1, stopCondition);
			}
			else
			{
				result = Bisection(function, middle, b, n - 1, stopCondition);
			}
		}
		else
		{
			result = middle;
			std::cout << n << " iterations left\n";

			if (!stopCondition(a, b, function->dx0(middle)))
			{
				std::cout << "The result doesn't meet the required deviation (eps).\n";
			}
			else
			{
				std::cout << "Value condition hit" << std::endl;
			}
		}

		return result;
	}
};