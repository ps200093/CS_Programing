#include <stdio.h>

void arrayCopy(int *a, int *b, int size);

void main()
{
	int a[10];
	int b[10];
	printf("10개의 데이터를 입력하세요 : ");
	for (int i = 0; i < 10; i++)
	{
		scanf("%d", &a[i]);
	}
	arrayCopy(b, a, 10);
	printf("a[] = ");
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", a[i]);
	}
	printf("\nb[] = ");
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", b[i]);
	}
}

void arrayCopy(int *a, int *b, int size)
{
	for (int i = 0; i < size; i++)
	{
		a[i] = b[i];
		// *(a + i) = *(b + i);  또는  *a++ = *b++;
	}
}