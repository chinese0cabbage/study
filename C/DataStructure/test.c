#include<stdio.h>
#include"math_method.h"
#include "LinearListByArray.h"
void main() {
	SeqList* L;
	L = InitL();
	printf("%d", L->Last);
}