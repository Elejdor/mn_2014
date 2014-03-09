#include <cstdio>
#include <cmath>

#define EPSL 0.01
#define EPS0 0.001

class Add1 {
public:

	static bool stopCond(double a, double b, double result)
	{
#define val_condition
#ifdef val_condition
		if (abs(result) < EPS0)
		{
			std::cout << "Value condition hit, eps = " << EPS0 << std::endl;
			return true;
		}
			
#else
		if (abs(b - a) < EPSL)
		{
			std::cout << "Set length condition hit, eps = " << EPSL << std::endl;
			return true;
		}
			
		
#endif
		return false;
	}

	static double Newton(double (foo)(double), double (fooDX)(double), double x0, int n, bool (stopCondition)(double, double, double))
	{
		double x1 = x0;
		x0 = x0 - (double)foo(x0)/fooDX(x0);

		double result = 0;

		if (n != 0 && !stopCond(x0, x1, foo(x0)))
		{
			result = Newton(foo, fooDX, x0, n - 1, stopCond);
		}
		else
		{
			result = x0;
			std::cout << n << " iterations left\n";
		}

		return result;
	}

	static double Bisection(double (foo)(double), double a, double b, int n, bool (stopCondition)(double, double, double))
	{
		double fooA = foo(a);
		double fooB = foo(b);

		double result = 0;
		double middle = (a + b) / 2;

		if (fooA*fooB < 0 && n != 0 && !stopCond(a, b, foo(middle)))
		{
			if (fooA * foo(middle) < 0)
			{
				result = Bisection(foo, a, middle, n - 1, stopCondition);
			}
			else
			{
				result = Bisection(foo, middle, b, n - 1, stopCondition);
			}
		}
		else
		{
			result = middle;
			std::cout << n << " iterations left\n";
		}

		return result;
	}
};