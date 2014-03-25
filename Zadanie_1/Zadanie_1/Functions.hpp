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
	virtual double dx2(double x) = 0;
	virtual char* toChars(){ return ""; };	
};

class Polynomial : public Function
{
public:
	char* toChars()
	{
		return "2 * x*x + 5 * x*x*x - 3 * x*x*x*x";
	}

	double dx0(double x)
	{
		return 2 * x*x + 5 * x*x*x - 3 * x*x*x*x; //f(x) = 0 for x = {-1/3, 0, 2}
	}

	double dx1(double x)
	{
		return -12*x*x+15*x+4; //f(x) = 0 for x = {-1/3, 0, 2}
	}

	double dx2(double x)
	{
		return 15 - 24 * x;
	}

};

class Exponential : public Function
{
public:
	char* toChars()
	{
		return "exp(x) - 10";
	}

	double dx0(double x)
	{
		return (double)exp(x) - 10; //f(x) = 0 for about x = 1.4307
	}

	double dx1(double x)
	{
		return (double)exp(x);
	}

	double dx2(double x)
	{
		return dx1(x);
	}

};

class Logarithmic : public Function
{
public:
	char* toChars()
	{
		return "2 * log10(x)";
	}

	double dx0(double x)
	{
		return 2 * log10(x); //f(x) = 0 for x = 1
	}

	double dx1(double x)
	{
		return (double)2 / (x*log(10));
	}

	double dx2(double x)
	{
		return (double)2 / log(10);
	}
};

#endif