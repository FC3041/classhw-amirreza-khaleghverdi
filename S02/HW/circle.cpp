#include <iostream>
#include <cmath>

class Circle {
private:
    double x, y;
    double r;    
    double perimeter;
    double area;

public:
    Circle(double x, double y, double r) : x(x), y(y), r(r) {
        calculatePerimeter();
        calculateArea();
    }

    void calculatePerimeter() {
        perimeter = 2 * M_PI * r;
    }

    void calculateArea() {
        area = M_PI * r * r;
    }

    double getPerimeter() const {
        return perimeter;
    }

    double getArea() const {
        return area;
    }

    bool isPointInside(double px, double py) const {
        double distanceSquared = (px - x) * (px - x) + (py - y) * (py - y);
        return distanceSquared <= r * r;
    }

    double distanceTo(const Circle& other) const {
        return std::sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y));
    }

    double distanceFromPointToCenter(double px, double py) const {
        return std::sqrt((px - x) * (px - x) + (py - y) * (py - y));
    }

    void printInfo() const {
        std::cout << "Circle with center (" << x << ", " << y << ") and radius " << r << ":\n";
        std::cout << "Perimeter: " << perimeter << "\n";
        std::cout << "Area: " << area << "\n";
    }
};

int main() {
    Circle circle(0, 0, 5);

    circle.printInfo();

    double px = 3, py = 4;
    if (circle.isPointInside(px, py)) {
        std::cout << "Point (" << px << ", " << py << ") is inside the circle.\n";
    } else {
        std::cout << "Point (" << px << ", " << py << ") is not inside the circle.\n";
    }

    double distance = circle.distanceFromPointToCenter(px, py);
    std::cout << "Distance from point (" << px << ", " << py << ") to the center of the circle: " << distance << "\n";

    return 0;
}