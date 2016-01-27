#include "AssociativeArray.h"
#include <iostream>
#include <conio.h>
#include <string>
#include "Hash.h"


using namespace std;
int main()
{
	//UnorderedMap<string, float> people;
	/*people["Anna"] = 1.7f;
	people["Alex"] = 2.7f;
	people["Boreau"] = 0.1f;
	people.Show();*/
	Hash<string, int> people(3);
	//people.Initialize(3);
	people["Anna"] = 1;
	people["Alex"] = 2;
	people["Boreau"] = 3;
	people["nAna"] = 3;
	people.Show();
	//people.Delete("Anna");
	//people.Show();
	cout << people.SearchValue(1) << endl;
	int k = 0;
	for (int i = 0; i < people.GetSize(); i++)
	{
		if (people.GetArr()[i].Count() > 1)
			++k;
	}
	cout << k / people.GetCount() << endl;
	_getch();
	return 0;
}

