#pragma once
#include <vector>
#include <stdexcept>
#include <cmath>


using namespace std;
template <class T>
class Matrix
{
private:
	vector<T> matrix;
	size_t rows, cols;
	static const Matrix<double> zero;
	static const Matrix<double> unit;
public:
	// ctor / dtor
	Matrix(size_t rows, size_t cols, T value) : matrix(rows * cols, value), rows(rows), cols(cols) {}
	Matrix(const Matrix &orig) = default; // copy
	Matrix(int size, vector<T> diagonal) : Matrix(size, size, 0)
	{
		for (int i = 0; i < size; i++)
			matrix[i + cols * i] = diagonal[i];
	}

	static Matrix<double> RotateY(double alpha)
	{
		auto res = zero;
		res[0][0] = cos(alpha);
		res[1][1] = 1;
		res[2][2] = cos(alpha);
		res[0][2] = -sin(alpha);
		res[2][0] = sin(alpha);
		return res;
	}

	//Matrix(Matrix &&temp) = default; // move
	~Matrix() {}

	// operators
	T *operator[](size_t row_index) { return &(matrix[row_index * cols]); }

	bool operator==(const Matrix &source) const
	{
		if (IsSameSize(source) == false)
			return false;
		for (int i = 0; i < rows * cols; i++)
		{
			if (matrix[i] != source[i])
				return false;
		}
		return true;
	}
	bool operator!=(const Matrix &source) const { return !((*this) == source); }

	bool IsSameSize(const Matrix &source) const
	{
		return (rows == source.rows) && (cols == source.cols);
	}

	Matrix &operator+=(const Matrix &source)
	{
		if (IsSameSize(source) == false)
			throw invalid_argument("Matrix diff size\n");
		for (int i = 0; i < rows * cols; i++)
			matrix[i] += source.matrix[i];
		return *this;
	}
	Matrix &operator+(const Matrix &source)
	{
		Matrix result(*this);
		a += source;
		return result;
	}

	Matrix &operator-=(const Matrix &source)
	{
		if (IsSameSize(source) == false)
			throw invalid_argument("Matrix diff size\n");
		for (int i = 0; i < rows * cols; i++)
			matrix[i] -= source.matrix[i];
		return *this;
	}
	Matrix &operator-(const Matrix &source)
	{
		Matrix result(*this);
		a -= source;
		return result;
	}

	Matrix &operator*(const Matrix &source)
	{
		if (cols != source.rows)
			throw invalid_argument("Matrix::operator*(): cols != rows\n");
		Matrix res(row, source.cols);
		for (int row_numb = 0; row_numb < rows; row_numb++)
		{
			for (int col_numb = 0; col_numb < source.cols; col_numb++)
			{
				T summ = 0;
				for (int i = 0; i < cols; i++)
				{
					summ += (*this)[row_numb][i] * source[i][col_numb];
				}
				res[row_numb][col_numb] = summ;
			}
		}
		return res;
	}
	Matrix &operator*=(const Matrix &source)
	{
		if (IsSameSize(source) == false || rows != cols)
			throw invalid_argument("Matrix::operator*=(): Matrix ...\n");
		(*this) = (*this) * source;
		return *this;
	}


	// interaction with vector and number

	std::vector<T> operator*(const std::vector<T> &v)
	{
		if (cols != v.size()){
			throw std::invalid_argument("Matrix::operator*(vector):Matrix row!=cols");
		}
		std::vector<T> res(rows);
		for (int row_n = 0; row_n < rows; row_n++)
		{
			T summ = 0;
			for (int i = 0; i < cols; i++)
			{
				summ += (*this)[row_n][i] * v[i];
			}
			res[row_n] = summ;

		}
		return res;
	}
	Matrix& operator*=(double a);
	Matrix operator*(double b)
	{
		Matrix a(*this);
		a *= b;
		return a;
	}

}; 