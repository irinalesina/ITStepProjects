#include<iostream>
#include<time.h>
#include<stdlib.h>
using namespace std;

int main() {
	const int n = 5;    // Size of matrix
	int a[n][n];

	srand(time(NULL));
	int max = a[0][0];



	for (int i = 0; i <= n - 1; i++) {						// Random number generator
		for (int j = 0; j <= n - 1; j++) {
			a[i][j] = rand() % 10;
			cout << a[i][j] << " ";
		}
		cout << "\n";
	}
	cout << "\n";

	

	for (int i = 0; i <= n - 1/2; i++) {									//  Variant A		
		for (int j = 0; j <= (n - 1)/2; j++) {
			if (j >= i) {
				cout << a[i][j] << " ";
			}
		}
		cout << "\n";
	}
	cout << "\n";


	int b = 0;
	for (int i = 0; i <= (n - 1)/2; i++) {									//  Variant I		
		for (int j = 2; j <= n - 1 - b; j++) {

			cout << a[i][j] << " ";

		}
		b++;
		cout << "\n";
	}
	cout << "\n";





}



