#include <iostream>
#include <iomanip>
#include <fstream>
#include <cmath>
#include <cstdlib>

using namespace std;

const double EPS   = 0.001; // dok�adno�� por�wnania z zerem
const int    MAXEQ = 100;          // maksymalna ilo�� r�wna� w uk�adzie

// Funkcja dokonuj�ca eliminacji niewiadomych. Je�li operacja
// si� powiedzie, zwraca true. Inaczej zwraca false.

bool EliminujX(int n, double AB[][MAXEQ+1], int WK[])
{
  int    i,j,k,tmp;
  double m;

  for(i = 0; i < n - 1; i++)
  {
    for(k = i, j = i + 1; j < n; j++)
      if(fabs(AB[i][WK[k]]) < fabs(AB[i][WK[j]])) k = j;
    tmp = WK[k]; WK[k] = WK[i]; WK[i] = tmp;
    if(fabs(AB[i][WK[i]]) < EPS) return false;
    for(j = i + 1; j < n; j++)
    {
      m = -AB[j][WK[i]] / AB[i][WK[i]];
      for(k = i + 1; k <= n; k++) AB[j][WK[k]] += m * AB[i][WK[k]];
    }
  }
  return true;
}

// Funkcja oblicza kolejne niewiadome x z macierzy AB
// przetworzonej przez funkcj� EliminujX().
// Je�li operacja si� powiedzie, zwraca true. Inaczej
// zwraca false.

bool ObliczX(int n, double X[], double AB[][MAXEQ+1], int WK[])
{
  int    i,j;
  double s;

  for(i = n - 1; i >= 0; i--)
  {
    if(fabs(AB[i][WK[i]]) < EPS) return false;
    s = AB[i][n];
    for(j = n - 1; j > i; j--) s -= AB[i][WK[j]] * X[WK[j]];
    X[WK[i]] = s / AB[i][WK[i]];
  }
  return true;
}

//-----------------------------------------------------
// Program g��wny
//-----------------------------------------------------

int main()
{
  ifstream fin;
  ofstream fout;
  int i,j,n,WK[MAXEQ+1];
  double AB[MAXEQ][MAXEQ+1], X[MAXEQ];

  cout.precision(5);     // 5 cyfr po przecinku
  cout.setf(ios::fixed); // format sta�oprzecinkowy

  cout << "Uklad rownan liniowych  - metoda eliminacji Gaussa n";


  fin.open("in.txt");
  fin >> n;
  if(n <= MAXEQ)
  {
    for(i = 0; i < n; i++)
    {
      WK[i] = i; // inicjujemy wektor kolumn
      for(j = 0; j <= n; j++) fin >> AB[i][j];
    }
    WK[n] = n;
    fin.close();

    cout << "\n---------------------------------------------------------\n"
            "Wyniki:\n\n";

    if(EliminujX(n,AB,WK) && ObliczX(n,X,AB,WK))  // Dokonujemy eliminacji oraz obliczania niewiadomych x
    {
      fout.open("out.txt");
      for(i = 0; i < n; i++)
      {
        cout << "x" << i + 1 << " = " << setw(12) << X[i] << endl;
        fout << X[i] << endl;
      }
      fout.close();
    }
    else cout << "Rozwiazanie ukladu rownan nie powiodlo sie\n";
  }
  else
  {
    fin.close();
    cout << "Zbyt wiele rownan!\n";
  }
  cout << "\n---------------------------------------------------------\n";
  system("pause");
  return 0;
}
