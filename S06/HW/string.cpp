#include<iostream>
#include<cstring>


using namespace std;

class MyStr
{
public:
    int m_size;
    char* m_PChars;

    MyStr() : m_size(0), m_PChars(nullptr) {}

    MyStr(const char* chars)
    {
        m_size = strlen(chars) + 1;
        m_PChars = (char*)malloc(sizeof(char) * m_size);
        strcpy(m_PChars, chars);
    }

    MyStr(const char* chars, int start, int count)
    {
        m_size = count + 1;
        m_PChars = (char*)malloc(sizeof(char) * m_size);
        for (int i = 0; i < count; i++)
        {
            m_PChars[i] = chars[start + i];
        }
        m_PChars[count] = '\0';
    }

    MyStr(const MyStr& other)
    {
        m_size = other.m_size;
        m_PChars = (char*)malloc(sizeof(char) * m_size);
        strcpy(m_PChars, other.m_PChars);
    }

    void printStr() const
    {
        cout << m_PChars << endl;
    }

    bool checkSubstr(const char* substr) const
    {
        if (!substr || !m_PChars)
        {
            return false;
        }

        int substrLen = 0;
        while (substr[substrLen] != '\0')
        {
            substrLen++;
        }

        for (int i = 0; i <= m_size - 1 - substrLen; i++)
        {
            bool found = true;
            for (int j = 0; j < substrLen; j++)
            {
                if (m_PChars[i + j] != substr[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                return true;
            }
        }

        return false;
    }

    int len() const
    {
        return m_size - 1;
    }

    void add(const MyStr& other)
    {
        int new_size = m_size + other.m_size - 1;
        char* new_PChars = (char*)malloc(sizeof(char) * new_size);
        strcpy(new_PChars, m_PChars);
        strcat(new_PChars, other.m_PChars);

        if (m_PChars)
        {
            free(m_PChars);
        }
        m_PChars = new_PChars;
        m_size = new_size;
    }
};

int main()
{
    MyStr s1;
    MyStr s2("malihe hajihosseini", 7, 12);
    s2.printStr();

    if (s2.checkSubstr("amir"))
        {
            cout << "found!" << endl;
        }
        else
        {
            cout << "not found!" << endl;
        }

    cout << "Length of s2: " << s2.len() << endl;

    MyStr s3("hello");
    s2.add(s3);
    s2.printStr();

    return 0;
}