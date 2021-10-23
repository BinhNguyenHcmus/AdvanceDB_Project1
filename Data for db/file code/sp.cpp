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

vector<string> split_at_commas(const string& row)
{
    vector<string> res;
    istringstream buf(row);
    string s;
    while (getline(buf, s, ','))
        res.push_back(s);
    return res;
}

int main()
{
    ifstream fin;
    ofstream fout;
    fin.open("Books.csv");
    fout.open("sanpham.csv");
    MyRandom mr1;
    MyRandom mr2;
    if (fin.is_open())
    {
        char comma;
        fout << "masp" << "," << "tensp" << "," << "slt" << "," << "mota" << "," << "gia" << endl;
        string data;
        int i = 0;
        while(getline(fin, data))
        {
            vector<string> read = split_at_commas(data);
            int slt = mr1.next(1,1000);
            long gia = mr2.next(100, 1000)*1000;
            string temp;
            read[1].erase(remove(read[1].begin(), read[1].end(), '\r'), read[1].end());
            if (i < 9) temp = "00000" + to_string(i + 1);
            else if (i >= 9 && i < 99) temp = "0000" + to_string(i + 1);
            else if (i >= 99 && i < 999) temp = "000" + to_string(i + 1);
            else if (i >= 999 && i < 9999) temp = "00" + to_string(i + 1);
            else if (i >= 9999 && i < 99999) temp = "0" + to_string(i + 1);
            else temp = to_string(i + 1);
            string masp = "SP" + temp;
            fout << masp << ',' << read[0] << ',' << slt << ',' << read[1] << ',' << gia << endl;
            i++;
        }
    }
    fin.close();
    fout.close();
    return 0;
}