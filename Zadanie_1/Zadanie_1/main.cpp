#include <cmath>
#include <iostream>

double foo(double x)
{
	return x*x-100;
}

class Add1 {
public:
	
	static double Bisection(double (foo)(double x), double a, double b, int n)
	{		
		double fooA = foo(a);
		double fooB = foo(b);

		double result = 0;
		double middle = (a + b) / 2;

		if (fooA*fooB < 0 && n != 0)
		{
			if (fooA * foo(middle) < 0)
			{
				result = Bisection(foo, a, middle, n - 1);
			}
			else
			{
				result = Bisection(foo, middle, b, n - 1);
			}
		}
		else if (fooA*fooB < 0 && n == 0)
		{
			result = middle;
		}
		
		return result;
	}
};

int main()
{
	double result = Add1::Bisection(foo, -1, 50, 10);

	system("pause");
	return 0;
}