#include <array>
#include <string>

int points(const std::array<std::string, 10>& games) {
    int length = games.size();

    int x = 0;
    int y = 0;

    for (int i = 0; i < length; i++)
    {
        if (games[i][0] > games[i][2])
            x += 3;

        else if (games[i][0] < games[i][2])
            y += 3; 

        else
        {
            x++; 
            y++; 
        }

    }
    return x;
}

int main()
{
    //string results[] = {"1:2", "3:1","2:3", "1:0"};

    //cout << results[0][2];
    //
}
