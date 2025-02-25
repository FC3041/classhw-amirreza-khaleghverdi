#include <iostream>
#include <stdlib.h>
using namespace std;

class MyList {
public:
    int m_size;
    int* m_Pnums;


    MyList(int size, int* nums) : m_size(size) {
        m_Pnums = (int*)malloc(sizeof(int) * size);
        for (int i = 0; i < m_size; i++) {
            m_Pnums[i] = nums[i];
        }
    }


    void append(int x) {
        resize(m_size + 1);
        m_Pnums[m_size - 1] = x;
    }


    int length() const {
        return m_size;
    }

private:
    void resize(int newsize) {
        int* newMem = (int*)malloc(sizeof(int) * newsize);
        for (int i = 0; i < m_size; i++) {
            newMem[i] = m_Pnums[i];
        }
        free(m_Pnums);
        m_size = newsize;
        m_Pnums = newMem;
    }
};

int main() {
    int nums[5] = {1, 2, 3, 4, 5};
    MyList m(5, nums);
    m.append(14);

    cout << "Length of the list: " << m.length() << endl;
    

    return 0;
}