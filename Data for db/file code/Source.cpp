#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <time.h>
using namespace std;

class Fullname
{
public:
    string middle;
    string first;
    string last;
};
class Fakename : public Fullname
{
public:
    Fakename next(vector<string> first, vector<string> middle, vector<string> last);
    void readfile(vector<string>& first, vector<string>& middle, vector<string>& last);
    friend ofstream& operator << (ofstream& f, Fakename& a);
};

class Address
{
public:
    string number;
    string street;
    string district;
    string ward;
    string province;
};
class FakeAddress :public Address
{
public:
    FakeAddress next(vector<string> street, vector<string> district, vector<string> ward, vector<string> province);
    void readfile(vector<string>& street, vector<string>& district, vector<string>& ward, vector<string>& province);
    friend ofstream& operator<< (ofstream& f, FakeAddress& a);
};
class FakeTel
{
public:
    string tel;
    void readfile(vector<string>& ope);
    FakeTel& next(vector<string>& ope);
    friend ofstream& operator<< (ofstream& f, FakeTel& a);
};
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
    if (a < b)
        return rand() % (b - a + 1) + a;
    return rand() % (a - b + 1) + b;
}
double MyRandom::nextDouble()
{
    return (double)rand() / RAND_MAX;
}
void Fakename::readfile(vector<string>& first, vector<string>& middle, vector<string>& last)
{
    //srand(time(NULL));
    ifstream f1, f2, f3;
    f1.open("sample-firstname.txt");
    f2.open("sample-middlenames.txt");
    f3.open("sample-lastnames.txt");
    string n1, n2, n3;
    if (f1.is_open())
    {
        while (getline(f1, n1))
        {
            first.push_back(n1);
        }
    }
    if (f2.is_open())
    {
        while (getline(f2, n2))
        {
            middle.push_back(n2);
        }
    }
    if (f3.is_open())
    {
        while (getline(f3, n3))
        {
            last.push_back(n3);
        }
    }
    f1.close();
    f2.close();
    f3.close();
}
Fakename Fakename::next(vector<string> first, vector<string> middle, vector<string> last)
{
    unsigned long size1 = first.size();
    unsigned long size2 = middle.size();
    unsigned long size3 = last.size();
    this->first = first[rand() % size1 + 0];
    this->middle = middle[rand() % size2 + 0];
    this->last = last[rand() % size3 + 0];
    return *this;
}
ofstream& operator << (ofstream& f, Fakename& a)
{
    f << a.first << " ";
    f << a.middle << " ";
    f << a.last << endl;
    return f;
}

void FakeAddress::readfile(vector<string>& street, vector<string>& district, vector<string>& ward, vector<string>& province)
{
    //srand(time(NULL));
    ifstream f1, f2, f3, f4;
    f1.open("sample-streetnames.txt");
    f2.open("sample-districtnames.txt");
    f3.open("sample-wardnames.txt");
    f4.open("sample-provinces.txt");
    string n1, n2, n3, n4;
    if (f1.is_open())
    {
        while (getline(f1, n1))
        {
            street.push_back(n1);
        }
    }
    if (f2.is_open())
    {
        while (getline(f2, n2))
        {
            district.push_back(n2);
        }
    }
    if (f3.is_open())
    {
        while (getline(f3, n3))
        {
            ward.push_back(n3);
        }
    }
    if (f4.is_open())
    {
        while (getline(f4, n4))
        {
            province.push_back(n4);
        }
    }
    f1.close();
    f2.close();
    f3.close();
    f4.close();
}
FakeAddress FakeAddress::next(vector<string> street, vector<string> district, vector<string> ward, vector<string> province)
{
    unsigned long size1 = street.size();
    unsigned long size2 = district.size();
    unsigned long size3 = ward.size();
    unsigned long size4 = province.size();
    this->number = to_string(rand() % 5000 + 1);
    this->street = street[rand() % size1 + 0];
    this->district = district[rand() % size2 + 0];
    this->ward = ward[rand() % size3 + 0];
    this->province = province[rand() % size4 + 0];
    return *this;
}
ofstream& operator << (ofstream& f, FakeAddress& a)
{
    f << a.number << "," << a.street << "," << a.ward << "," << a.district << a.province << endl;
    return f;
}

void FakeTel::readfile(vector<string>& ope)
{
    ifstream fin;
    fin.open("sample-operators.txt");
    if (fin.is_open())
    {
        string a;
        while (getline(fin, a))
        {
            ope.push_back(a);
        }
    }
    fin.close();
}
FakeTel& FakeTel::next(vector<string>& ope)
{
    unsigned long size = ope.size();
    this->tel = ope[rand() % (size + 0)];
    for (int i = 0; i < 7; i++)
    {
        this->tel.append(to_string(rand() % 9 + 0));
    }
    return *this;
}
ofstream& operator<<(ofstream& f, FakeTel& a)
{
    f << a.tel;
    return f;
}

string randomDate()
{
    int d, m, y;
    string temp, td, tm;
    MyRandom mr;
    m = mr.next(1, 12);
    y = mr.next(1950, 2000);
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
        if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
            d = mr.next(1, 29);
        d = mr.next(1, 28);
    }
    }
    if (d < 10) td = "0" + to_string(d); else td = to_string(d);
    if (m < 10) tm = "0" + to_string(m); else tm = to_string(m);
    temp = tm + "/" + td + "/" + to_string(y);
    return temp;
}
int main()
{
    vector<string> street;
    vector<string> district;
    vector<string> ward;
    vector<string> province;
    vector<string> first;
    vector<string> middle;
    vector<string> last;
    vector<string> ope;
    FakeAddress a;
    Fakename n;
    FakeTel t;
    string date;
    a.readfile(street, district, ward, province);
    n.readfile(first, middle, last);
    t.readfile(ope);
    ofstream f;
    f.open("data.csv");
    srand(time(NULL));
    if (f.is_open())
    {
        for (long i = 0; i < 100000; i++)
        {
            a.next(street, district, ward, province);
            n.next(first, middle, last);
            t.next(ope);
            date = randomDate();
            string temp;
            if (i < 9) temp = "00000" + to_string(i + 1);
            else if (i >= 9 && i < 99) temp = "0000" + to_string(i + 1);
            else if (i >= 99 && i < 999) temp = "000" + to_string(i + 1);
            else if (i >= 999 && i < 9999) temp = "00" + to_string(i + 1);
            else if (i >= 9999 && i < 99999) temp = "0" + to_string(i + 1);
            else temp = to_string(i + 1);
            string ma = "KH" + temp;
            if (i < 66667)
            {
                f << ma << ',' << n.first << " " << n.middle << ',' << n.last << ',' << date << ',' << a.number << ',' << a.street << ',' << a.ward << ',' << a.district << ',' << "TPHCM" << ',' << t.tel << endl;
            }
            else
                f << ma << ',' << n.first << " " << n.middle << ',' << n.last << ',' << date << ',' << a.number << ',' << a.street << ',' << a.ward << ',' << a.district << ',' << a.province << ',' << t.tel << endl;
        }
    }
    else cout << "Failed" << endl;
    f.close();
}

