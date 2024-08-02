#include <stdio.h>

void getSumDiff(int x, int y, int *pSum, int *pDiff);

void main()
{
	int x, y, sum, diff;
	printf("첫 번째 수를 입력하세요 : ");
	scanf("%d", &x);
	printf("두 번째 수를 입력하세요 : ");
	scanf("%d", &y);
	getSumDiff(x, y, &sum, &diff);
	printf("원소들의 합 = %d\n", sum);
	printf("워소들의 차 = %d\n", diff);
}

void getSumDiff(int x, int y, int *pSum, int *pDiff)
{
	*pSum = x + y;
	*pDiff = x - y;
}