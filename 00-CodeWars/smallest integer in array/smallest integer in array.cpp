#include <vector>
#include <iostream>

using namespace std;

int findSmallest(int list[])
{
	int length = sizeof(list) / sizeof(list[0]);
	int Min = list[0];
	for (int i = 0; i < length; i++) {
		if (list[i] < Min)
			Min = list[i];
	}
	return Min;
}
int main() {

	int nums[] = { 1, 2, 3, 4 };

	cout<< sizeof(nums)/sizeof(nums[0]) << endl;

	return 0; 
}