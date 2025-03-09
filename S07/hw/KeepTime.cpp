#include <iostream>
#include <string>
#include <windows.h>

using namespace std;

class KeepTime
{
public:
    KeepTime(const string& name)
        : m_name(name), m_startTime(GetTickCount64())
    {
    }

    ~KeepTime()
    {
        unsigned long long endTime = GetTickCount64();
        cout << m_name << " took " << (endTime - m_startTime) << " ms" << endl;
    }

private:
    string m_name;
    unsigned long long m_startTime;
};

int main()
{
    {
        int d;
        KeepTime t("for loop 3000000");
        for (int i=0;i<30*100000;i++)
        {
            d=i;
        }
    }

    return 0;
}