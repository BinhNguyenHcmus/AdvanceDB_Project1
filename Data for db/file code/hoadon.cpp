#include <iostream>
#include <string>
#include <vector>
#include <fstream>
using namespace std;

class MyRandom
{
    int ran;
public:
    MyRandom();
    int next();
    int next(int x);
    int next(int a, int b);
    double nextDouble();
};
MyRandom::MyRandom()
{
    //srand(time(NULL));
    ran = rand();
}
int MyRandom::next()
{
    return rand() % RAND_MAX + 0;
}
int MyRandom::next(int x)
{
    return rand() % x + 0;
}
int MyRandom::next(int a, int b)
{
    if (a<b)
        return rand() % (b - a + 1) + a;
    return rand()%(a - b + 1) + b;
}
string randomDate()
{
    int d, m, y;
    string temp, td, tm;
    MyRandom mr;
    m = mr.next(1, 12);
    switch (m)
    {
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
    {
        d = mr.next(1, 31);
        break;
    }
    case 4:
    case 6:
    case 9:
    case 11:
    {
        d = mr.next(1, 30);
    }
    case 2:
    {
        d = mr.next(1, 28);
    }
    }
    switch(m)
    {
        case 7:
        case 8:
        case 9:
        case 10:
        case 12:
        case 11:
        {
            y = 2020;
            break;
        }
        case 1:
        case 2:
        case 3:
        case 4:
        {
            y = 2021;
            break;
        }
        case 5:
        case 6:
        {
            y = mr.next(2020,2021);
            break;
        }
    }
    if (d < 10) td = "0" + to_string(d); else td = to_string(d);
    if (m < 10) tm = "0" + to_string(m); else tm = to_string(m);
    temp = tm + "/" + td + "/" + to_string(y);
    return temp;
}
int main ()
{
    string date;
    ofstream f;
    f.open("hoadon.csv");
    srand(time(NULL));
    MyRandom mr;
    if (f.is_open())
    {
        f << "mahd" << ',' << "makh" << ',' << "ngaylap" << ',' << "tongtien" << endl;
        for (long i = 0; i < 500000; i++)
        {
            date = randomDate();
            string temp;
            if (i < 9) temp = "00000" + to_string(i + 1);
            else if (i >= 9 && i < 99) temp = "0000" + to_string(i + 1);
            else if (i >= 99 && i < 999) temp = "000" + to_string(i + 1);
            else if (i >= 999 && i < 9999) temp = "00" + to_string(i + 1);
            else if (i >= 9999 && i < 99999) temp = "0" + to_string(i + 1);
            else temp = to_string(i + 1);
            string mahd = "HD" + temp;
            int kh = mr.next(1, 100000);
            string temp2;
            if (kh < 9) temp2 = "00000" + to_string(kh + 1);
            else if (kh >= 9 && kh < 99) temp2 = "0000" + to_string(kh + 1);
            else if (kh >= 99 && kh < 999) temp2 = "000" + to_string(kh + 1);
            else if (kh >= 999 && kh < 9999) temp2 = "00" + to_string(kh + 1);
            else if (kh >= 9999 && kh < 99999) temp2 = "0" + to_string(kh + 1);
            else temp2 = to_string(kh + 1);
            string makh = "KH" + temp2;

            f << mahd << ',' << makh << ',' << date << ',' << "0" << endl;
        }
    }
}