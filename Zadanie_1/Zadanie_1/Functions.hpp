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
		return -12*x*x + 15 * x + 4;
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