#include <iostream>
#include <stdexcept>
using namespace std;

class Vector {
private:
    int* m_data;
    size_t m_size;
    size_t m_capacity;

    void resize(size_t new_capacity) {
        int* new_data = new int[new_capacity];
        for (size_t i = 0; i < m_size; ++i) {
            new_data[i] = m_data[i];
        }
        delete[] m_data;
        m_data = new_data;
        m_capacity = new_capacity;
    }

public:

    Vector() : m_data(nullptr), m_size(0), m_capacity(0) {}

    ~Vector() {
        delete[] m_data;
    }

    size_t size() const {
        return m_size;
    }

    size_t capacity() const {
        return m_capacity;
    }

    void push_back(int value) {
        if (m_size >= m_capacity) {
            resize(m_capacity == 0 ? 1 : m_capacity * 2);
        }
        m_data[m_size++] = value;
    }

    void insert(size_t index, int value) {
        if (index > m_size) {
            throw out_of_range("Index out of range");
        }
        if (m_size >= m_capacity) {
            resize(m_capacity == 0 ? 1 : m_capacity * 2);
        }

        for (size_t i = m_size; i > index; --i) {
            m_data[i] = m_data[i - 1];
        }
        m_data[index] = value;
        ++m_size;
    }

    void erase(size_t index) {
        if (index >= m_size) {
            throw out_of_range("Index out of range");
        }
        
        for (size_t i = index; i < m_size - 1; ++i) {
            m_data[i] = m_data[i + 1];
        }
        --m_size;
    }

    void clear() {
        delete[] m_data;
        m_data = nullptr;
        m_size = 0;
        m_capacity = 0;
    }

    int& operator[](size_t index) {
        if (index >= m_size) {
            throw out_of_range("Index out of range");
        }
        return m_data[index];
    }

    void print() const {
        for (size_t i = 0; i < m_size; ++i) {
            cout << m_data[i] << " ";
        }
        cout << endl;
    }
};

int main() {
    Vector vec;

    vec.push_back(10);
    vec.push_back(20);
    vec.push_back(30);
    cout << "After push back: ";
    vec.print();

    vec.insert(1, 15);
    cout << "After insert: ";
    vec.print();

    vec.erase(2);
    cout << "After erase: ";
    vec.print();

    vec.clear();
    cout << "After clear: ";
    vec.print();

    vec.push_back(100);
    vec.push_back(200);
    cout << "After push_back (after clear): ";
    vec.print();

    return 0;
}