#include <iostream>
#include <cstring>
using namespace std;

class String {
private:
    char* m_data; 
    size_t m_size; 

public:
    
    String(const char* str = "") {
        m_size = strlen(str);
        m_data = new char[m_size + 1];
        strcpy(m_data, str);
    }
    
    ~String() {
        delete[] m_data;
    }
    
    void assign(const char* str) {
        delete[] m_data;
        m_size = strlen(str);
        m_data = new char[m_size + 1];
        strcpy(m_data, str);
    }
    
    const char* c_str() const {
        return m_data;
    }
    
    size_t size() const {
        return m_size;
    }
    
    void append(const char* str) {
        size_t new_size = m_size + strlen(str);
        char* new_data = new char[new_size + 1];
        strcpy(new_data, m_data); 
        strcat(new_data, str);
        delete[] m_data;
        m_data = new_data;
        m_size = new_size;
    }
   
    void append(const String& other) {
        append(other.c_str());
    }
};

int str1() {
    String name("ali");
    String name2;
    name2.assign("mozhdeh");
    cout << name.c_str() << ":" << name.size() << endl;
    name.append(" + ");
    name.append(name2);
    cout << name.c_str() << endl;
    return 0;
}

int main() {
    str1();
    return 0;
}