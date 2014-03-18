#ifndef FUNCTIONS_HPP
#define FUNCTIONS_HPP
#include <cstdio>

class Function
{
private:
	double x1, x2, xN;
public:
	virtual double dx0(double x) = 0;
	virtual double dx1(double x) = 0;
};

class Polynomial : public Function
{
public:
	double dx0(double x)
	{
		return 2 * x*x + 5 * x*x*x - 3 * x*x*x*x; //f(x) = 0 for x = {-1/3, 0, 2}
	}

	double dx1(double x)
	{
		return 4 * x + 15 * x*x - 12 * x*x*x; //f(x) = 0 for x = {-1/3, 0, 2}
	}
	double dx2 (double x)
	{
           return 4 + 30*x - 36*x*x;
    }
};
class Sinus : public Function
{
public:
	double dx0(double x)
	{
		return sin(0.5*x);
	}

	double dx1(double x)
	{
		return 0.5*cos(0.5*x); //f(x) = 0 for x = {-1/3, 0, 2}
	}
	double dx2 (double x)
	{
		return -0.25*sin(0.5*x);
    }
};

class Exponential : public Function
{
public:
	double dx0(double x)
	{
		return pow(5, x) - 10; //f(x) = 0 for about x = 1.4307
	}

	double dx1(double x)
	{
		return pow(5, x)*log(5);
	}
	double dx2 (double x)
	{
           return pow(5, x)*pow(log(5),2);
 }
};

class Logarithmic : public Function
{
public:
	double dx0(double x)
	{
		return 2 * log10(x); //f(x) = 0 for x = 1
	}

	double dx1(double x)
	{
		return (double)2 / (x*log(10));
	}
	
};

#endif
