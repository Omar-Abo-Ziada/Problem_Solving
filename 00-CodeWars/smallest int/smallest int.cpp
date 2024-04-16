#include <vector>

using namespace std;

int findSmallest(vector <int> list)
{
	int Min = list[0];

	for (int i = 0; i < list.size(); i++)
	{
		if (list[i] < Min)
			Min = list[i];
	}

	return Min;
}