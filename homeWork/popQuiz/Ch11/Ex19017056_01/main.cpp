#include <stdio.h>

void main()
{
	int a = 0x12345678;
	int *pa = &a;
	char *pc = (char*)&a;
	printf("%u %u %u\n", &a, pa, pc);

	printf("%x\n", *pa);
	printf("%x\n", *pc);
	printf("%x\n", *(pc + 1));
	printf("%x\n", *(pc + 2));
	printf("%x\n", *(pc + 3));

	for (int i = 0; i < 4; i++) {
		printf("%x\n", *pc++);
	}
	/*printf("%x\n", *pc++);
	printf("%x\n", *pc++);
	printf("%x\n", *pc++);
	printf("%x\n", *pc++);*/

	int aa[5] = { 1, 2, 3, 4, 5 };
	int* paa = aa;
	int* pbb = &aa[0];
	for (int i = 0; i < 5; i++)
	{
		printf("%d ", aa[i]);
	}
	printf("\n또는\n");
	for (int i = 0; i < 5; i++)
	{
		printf("%d ", *(aa + i));
	}
	printf("\n또는\n");
	for (int i = 0; i < 5; i++)
	{
		printf("%d ", *paa++);
	}
	/*for (int i = 0; i < 5; i++)
	{
		printf("%d", *aa++); //*aa++은 오류(변수가 필요하다고 뜸), 배열 이름은 주소 상수이기 때문에
	}*/

	int a2[2][3] = { {1, 2, 3}, {4, 5, 6} };
	//a2[0], a2[1], a2라는 주소 상수가 존재
	int *pa2 = a2[0];
	int *pb2 = a2[1];
	// int *pc2 = a2; a2는 12byte 메모리의 주소, int(4byte)에는 넣을 수 없다.
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			printf("%d ", a2[i][j]);
		}
	}
	printf("\n또는\n");
	for (int j = 0; j < 3; j++)
	{
		printf("%d ", *pa2++);
	}
	printf("\n또는\n");
	for (int i = 0; i < 3; i++)
	{
		printf("%d ", *pb2++);
	}
}