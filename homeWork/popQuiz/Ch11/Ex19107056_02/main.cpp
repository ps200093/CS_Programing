#include <stdio.h>

void swap(int x, int y);
void swapp(int *px, int *py);
void calc(int op1, int op2, int *pSum, int *pSub, int *pMul, int *pDiv);

void main()
{
	int x = 10, y = 5;
	printf("Before : %d, %d\n", x, y);
	swap(x, y);
	printf("After : %d, %d\n", x, y);
	printf("Before : %d, %d\n", x, y);
	swapp(&x, &y);
	printf("After : %d, %d\n", x, y);
	int sum, sub, mul, div;
	calc(x, y, &sum, &sub, &mul, &div);
	printf("Sum = %d, Sub = %d, Mul = %d, Div = %d\n", sum, sub, mul, div);
}

void swap(int x, int y)
{
	int temp = x;
	x = y;
	y = temp;
}

void swapp(int *px, int *py)
{
	int temp = *px;
	*px = *py;
	*py = temp;
}

void calc(int op1, int op2, int *pSum, int *pSub, int *pMul, int *pDiv)
{
	*pSum = op1 + op2;
	*pSub = op1 - op2;
	*pMul = op1 * op2;
	*pDiv = op1 / op2;
}