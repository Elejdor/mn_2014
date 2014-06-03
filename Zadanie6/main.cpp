#include <iostream>
#include "rozniczka.h"
#include "gnuplot_i.hpp"
//#include <vector>
#include <stdlib.h>
#define GNUPLOT_PATH "C:/gnuplot/bin"
using namespace std;
//typedef vector <double> myvec;
void rysuj(double,double,myvec,myvec,myvec, string);
int main()
{
    Gnuplot::set_GNUPlotPath( GNUPLOT_PATH );
    double a,b,y1,y2;
    myvec x_fun,RK4_y1,RK4_y2,R_y1,R_y2;
    int kroki;
    char znak;
    do
    {
        x_fun.clear();
        RK4_y1.clear();
        RK4_y2.clear();
        R_y1.clear();
        R_y2.clear();
        system("cls");
        cout << "Podaj poczatek przedzialu rozniczkowania: ";
        cin >> a;
        cout << "Podaj koniec przedzialu rozniczkowania: ";
        cin >> b;
        cout << "Podaj ilosc krokow: ";
        cin >> kroki;
        cout << "Podaj warunek poczatku dla 1. rozwania: ";
        cin >> y1;
        cout << "Podaj warunek poczatku dla 2. rozwania: ";
        cin >> y2;
        RK4_y1.push_back(y1);
        RK4_y2.push_back(y2);
        R_y1.push_back(y1);
        R_y2.push_back(y2);
        licz(a,b,kroki,x_fun,RK4_y1,RK4_y2,R_y1,R_y2);
        rysuj(a,b,x_fun,RK4_y1,R_y1,"f1");
        rysuj(a,b,x_fun,RK4_y2,R_y2,"f2");
        cout << "\nCzy chcesz podac inne dane(t/n)? ";
        cin >> znak;
    }
    while(znak=='t' or znak=='T');

    return 0;
}
void rysuj(double a, double b, myvec x_fun, myvec RK4_y, myvec r_y, string tytul)
{
    Gnuplot main_plot;
    main_plot.set_title(tytul);
    main_plot.set_style("lines");
    main_plot.set_grid();
    //main_plot.set_xrange( a-0.1 , b+0.1 );
    double min_y1=0,max_y1=0;
    for (int i=0;i<RK4_y.size();i++)
    {
        if(RK4_y[i]>max_y1) max_y1=RK4_y[i];
        else if (RK4_y[i]<min_y1) min_y1=RK4_y[i];
    }
    double min_y2=0,max_y2=0;
    for (int i=0;i<r_y.size();i++)
    {
        if(r_y[i]>max_y2) max_y2=r_y[i];
        else if (r_y[i]<min_y1) min_y2=r_y[i];
    }
    if(min_y1>min_y2)min_y1=min_y2;
    if(max_y1<max_y2)max_y1=max_y2;
   // main_plot.set_yrange(min_y1,max_y1);
    main_plot.plot_xy(x_fun,RK4_y,"Rungego-Kuty 4 rzedu");
    main_plot.plot_xy(x_fun,r_y,"wzor Ralsona");
    system("pause");
}

