#include <iterator>
#include <iostream>
#include <fstream>
#include <sstream>
#include <vector>
#include <string>
#include <time.h>
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

int main()
{
    ofstream f;
    long i = 0;
    f.open("cthd.csv");
    MyRandom mr1, mr2, mr3, mr4;
    long count = 0;
    if (f.is_open())
    {
        f << "mahd" << "," << "masp" << "," << "sl" << "," << "giaban" << "," << "giagiam" << "," << "thanhtien" << endl;
        for (long i = 0; i < 500000; i++)
        {
            if (count == 1000000) break;
            int nsp = mr1.next(1,3);
            string temp;
            if (i < 9) temp = "00000" + to_string(i + 1);
            else if (i >= 9 && i < 99) temp = "0000" + to_string(i + 1);
            else if (i >= 99 && i < 999) temp = "000" + to_string(i + 1);
            else if (i >= 999 && i < 9999) temp = "00" + to_string(i + 1);
            else if (i >= 9999 && i < 99999) temp = "0" + to_string(i + 1);
            else temp = to_string(i + 1);
            string mahd = "HD" + temp;
            for (int j = 0; j < nsp; j++)
            {
                if (count == 1000000) break;
                int msp = mr2.next(1, 10000);
                int sl = mr4.next(1,4);
                int giagiam = mr3.next(10,50)*1000;
                string temp;
                if (msp < 9) temp = "00000" + to_string(msp);
                else if (msp >= 9 && msp < 99) temp = "0000" + to_string(msp);
                else if (msp >= 99 && msp < 999) temp = "000" + to_string(msp);
                else if (msp >= 999 && msp < 9999) temp = "00" + to_string(msp);
                else if (msp >= 9999 && msp < 99999) temp = "0" + to_string(msp + 1);
                else temp = to_string(msp);
                string masp = "SP" + temp;
                f << mahd << "," << masp << "," << sl << "," << 0 << "," << giagiam << "," << 0 << endl;
                count++;
            }
        }
    }
}
