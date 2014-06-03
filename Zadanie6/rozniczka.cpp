#include <rozniczka.h>
#include <math.h>
#include <iostream>
using namespace std;
//definicje funki, które rozniczkujemy

double e(double t){
    return 120*sin(100*M_PI*t);
}

double f1(double t, double x1, double x2){
   double R1 = 0.05;
   double L1 = 1/(100*M_PI);

   return (e(t)-R1*x1-(x1/x2))/L1;

}

double f2(double t, double x1, double x2){
    double O = 5+pow(10,-5);
    double U = 70;

    return (x2/O)*(((pow(x1,2))/(pow(x2,2))*pow(U,2))-1);
}
/*
  a[]-tablica wspolczników
  y[]- tablica y-ós ze wcześniejszego rozniczkowanie
*/
void rozniczkowanie(double x, double h, double a[],double y[])
{
    double k[2][4];
    //I rząd
    k[0][0] = h*f1(x,y[0],y[1]);
    k[1][0] = h*f2(x,y[0],y[1]);
    //II rząd
    k[0][1] = h*f1(x+a[0]*h, y[0]+a[1]*k[0][0], y[1]+a[1]*k[1][0]);
    k[1][1] = h*f2(x+a[0]*h, y[0]+a[1]*k[0][0], y[1]+a[1]*k[1][0]);
    //III rzad
    k[0][2] = h*f1(x+a[2]*h, y[0]+a[3]*k[0][0]+a[4]*k[0][1], y[1]+a[3]*k[0][1]+a[4]*k[1][1]);
    k[1][2] = h*f2(x+a[2]*h, y[0]+a[3]*k[0][0]+a[4]*k[0][1], y[1]+a[3]*k[0][1]+a[4]*k[1][1]);
    //IV rzad
    k[0][3] = h*f1(x+h, y[0]+a[5]*k[0][0]+a[6]*k[0][1]+a[7]*k[0][2],y[1]+a[5]*k[0][1]+a[6]*k[1][1]+a[7]*k[1][2]);
    k[1][3] = h*f2(x+h, y[0]+a[5]*k[0][0]+a[6]*k[0][1]+a[7]*k[0][2],y[1]+a[5]*k[0][1]+a[6]*k[1][1]+a[7]*k[1][2]);
    //wyniki
    y[0] = y[0]+a[8]*k[0][0]+a[9]*k[0][1]+a[10]*k[0][2]+a[11]*k[0][3];
    y[1] = y[1]+a[8]*k[1][0]+a[9]*k[1][1]+a[10]*k[1][2]+a[11]*k[1][3];
}
void licz(double a, double b, int krok, myvec &x, myvec &RK4_y1, myvec &RK4_y2, myvec &Ralson_y1, myvec &Ralson_y2)
{
    double h= fabs(b-a)/(double) krok;
    //wspolczynniki dla wzoru Ralsona
    double ralson[]={0.4,0.4,0.45573726,0.29697760,0.15875966,0.21810038,-3.050986471,3.83286432,0.17476028,-0.55148053,1.20553547,0.17118478};
    //wspolczynniki dla metody klasycznej
    double rk4[]={0.5,0.5,0.5,0,0.5,0,0,1,0.16666667,0.33333333,0.33333333,0.16666667};
    double tempRK[]={RK4_y1[0],RK4_y2[0]};
    double tempR[]={Ralson_y1[0],Ralson_y2[0]};
    x.push_back(a);
    //obliczenia
    for(int i=1;i<krok;i++)
    {
        rozniczkowanie(x[i-1],h,rk4,tempRK);
        RK4_y1.push_back(tempRK[0]);
        RK4_y2.push_back(tempRK[1]);
        rozniczkowanie(x[i-1],h,ralson,tempR);
        Ralson_y1.push_back(tempR[0]);
        Ralson_y2.push_back(tempR[1]);
        x.push_back(a+i*h);
    }
}

