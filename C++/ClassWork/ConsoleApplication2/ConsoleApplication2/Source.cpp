#include <iostream>
#include <cstring>
using namespace std;
class PriorityQueue
{
	int arr[32];
	int curr_size=0;
public:
	PriorityQueue()
	{
		memset(arr, -1, sizeof(arr));
	}
	void push(int n){
		if (curr_size == 32){
			cout << "Queue overflow" << endl;
			return;
		}
		for (int i = 0; i <= curr_size; ++i){
			if (n >= arr[i]){
				for (int j = curr_size; j>i; --j)
					arr[j] = arr[j - 1];
				arr[i] = n;
				++curr_size;
				return;
			}
		}
	}
	void pop(){
		if (curr_size){
			for (int i = 1; i < curr_size; ++i){
				arr[i - 1] = arr[i];
			}
			--curr_size;
		}
		else cout << "Queue is empty" << endl;
	}
	void show(){
		for (int i = 0; i < curr_size; ++i)
			cout << arr[i] << " ";
		cout << endl;
	}
};
int main()
{
	PriorityQueue a;
	a.pop();
	a.push(5);
	a.show();
	a.push(6);
	a.show();
	a.push(7);
	a.show();
	a.push(8);
	a.show();
	a.push(3);
	a.show();
	a.push(1);
	a.show();
	a.push(9);
	a.show();
	a.push(15);
	a.show();
	a.push(0);
	for (int i = 0; i < 32; ++i)
		a.push(7);
	for (int i = 0; i < 40; ++i){
		a.show();
		a.pop();
	}
}