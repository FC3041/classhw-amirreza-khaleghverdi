#include<iostream>
using namespace std;;
#include<math.h>

class point 
{
    public:
        double x;
        double y;

    point (point* q)
    (
        x=q->x;
        y=q-> y;
    )
    point (double w)
    (
        x=w;
        y=w;
    )
    void print_point()
    {
    cout << "x: " <<x<< ", y" << y <<endl;
    }


    double points_distance(point w)
    {
    double x_diff=x-w.x;
    double y_diff=y-w.y;
    return sqrt(x_diff*x_diff+y_diff*y_diff);
    }
};



int main()
{

    point p1;

    p1.x=4;
    p1.y=5;
    //print_point(p1);
    p1.print_point();

    point p2;
    p2.x =-5;
    p2.y =10;

    cout <<p1.x<<endl;
    double r=points_distance(p1,p2);


    int a;
    ::cin>>a;
    ::cout<<"a:"<<a<<::endl;
}