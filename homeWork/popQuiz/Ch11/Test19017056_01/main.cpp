#include <stdio.h>

void getSumDiff(int x, int y, int *pSum, int *pDiff);

void main()
{
	int x, y, sum, diff;
	printf("ù ��° ���� �Է��ϼ��� : ");
	scanf("%d", &x);
	printf("�� ��° ���� �Է��ϼ��� : ");
	scanf("%d", &y);
	getSumDiff(x, y, &sum, &diff);
	printf("���ҵ��� �� = %d\n", sum);
	printf("���ҵ��� �� = %d\n", diff);
}

void getSumDiff(int x, int y, int *pSum, int *pDiff)
{
	*pSum = x + y;
	*pDiff = x - y;
}