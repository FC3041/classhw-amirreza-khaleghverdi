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

    ~MyList() {
        free(m_Pnums);
    }

    void append(int x) {
        resize(m_size + 1);
        m_Pnums[m_size - 1] = x;
    }

    int len() const {
        return m_size;
    }

    int pop() {
        
        int lastElement = m_Pnums[m_size - 1];
        resize(m_size - 1);
        return lastElement;
    }

    int at(int index) const {
        return m_Pnums[index];
    }

    void reverse()
    {
        for(int i=0;i<=abs(m_size)/2;i++)
        {
            int temp=m_Pnums[i];
            m_Pnums[i]=m_Pnums[m_size-i-1];
            m_Pnums[m_size-i-1]=temp;
        }
    }

private:
    void resize(int newsize) {
        int* newMem = (int*)malloc(sizeof(int) * newsize);
        for (int i = 0; i < m_size && i < newsize; i++) {
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

    cout << "the length is : " << m.len() << endl;
    int poppedValue = m.pop();
    cout << "Popped value is: " << poppedValue << endl;
    cout << "length after pop: " << m.len() << endl;
    int index = 2;
    cout << "element at index " << index << ": " << m.at(index) << endl;

    return 0;
}