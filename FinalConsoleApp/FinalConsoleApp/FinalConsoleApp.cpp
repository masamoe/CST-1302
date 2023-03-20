// FinalConsoleApp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

struct Pyramid
{
    int length;
    int width;
    int height;

    Pyramid(int l, int w, int h) : length(l), width(w), height(h) {}
};

int findVolume(Pyramid input)
{
    return ((input.length * input.width) * input.height) / 3;
}

void compareVolumes(Pyramid input1, Pyramid input2)
{
    std::cout << "Calling findVolume for pyramidOne:" << std::endl;
    int volume1 = findVolume(input1);
    std::cout << "Pyramid 1 volume: " << volume1 << std::endl;
    std::cout << "Calling findVolume for pyramidTwo:" << std::endl;
    int volume2 = findVolume(input2);
    std::cout << "Pyramid 2 volume: " << volume2 << std::endl;

    std::cout << "Calling findVolume for pyramidTwo:" << std::endl;
    if (volume1 > volume2)
    {
        std::cout << "Pyramid 1 is larger than Pyramid 2 by " << volume1 - volume2 << " cubic cenitmeters." << std::endl;
    }
    else if (volume1 < volume2)
    {
        std::cout << "Pyramid 2 is larger than Pyramid 1 by " << volume2 - volume1 << " cubic cenitmeters." << std::endl;
    }
    else
    {
        std::cout << "Pyramid 1 and Pyramid 2 are the same size" << std::endl;
    }
}

int main()
{
    Pyramid pyramidOne(10, 10, 10);
    Pyramid pyramidTwo(5, 5, 5);

    compareVolumes(pyramidOne, pyramidTwo);
}
