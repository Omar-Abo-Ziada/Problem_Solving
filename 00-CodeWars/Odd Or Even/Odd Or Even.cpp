// Odd Or Even.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std; 

void OddOrEven(int nums[], int size) {
    int Sum = 0; 
    for (int i = 0; i < size; i++)
    {
        Sum += nums[i];
    }

    if (Sum % 2 == 0)
        cout << "even"<<endl;

    else
        cout << "odd"<<endl; 
}

int main()
{
    //Given a list of integers, determine whether the sum of its elements is odd or even.

    //    Give your answer as a string matching "odd" or "even".

    //    If the input array is empty consider it as : [0] (array with a zero).

    int nums1[] = {0, 1, 2 };
    int nums2[] = {0, -1, 5 , 4 };
    int nums3[] = {20, 2, 0 , -2 , -6 };

    OddOrEven(nums1 , 3);
    OddOrEven(nums2 , 4);
    OddOrEven(nums3 , 5);
   
}
