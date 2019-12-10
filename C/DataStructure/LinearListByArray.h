#pragma once
#include <malloc.h>
#define MAX_SIZE 100
typedef struct
{
	int Data[MAX_SIZE];
	int Last;
}SeqList;

//初始化一个类型为LNode的线性表,Last表示最后一个元素所在位置的下一位
SeqList* InitL() {
	SeqList* L;
	L = (SeqList*)malloc(sizeof(SeqList));
	L->Last = 0;
	return L;
}

//向线性表的末尾插入num，成功则返回最后一个元素所在位置的下一位，失败则返回-1
int InsertLSeqList(SeqList* seqList, int place, int num) {
	if (seqList->Last == MAX_SIZE)
	{
		printf("当前线性表已满");
	}
	if (place<0 || place>MAX_SIZE - 1)
	{
		return -1;
		printf("插入位置不合法");
	}
	else
	{
		if (place > seqList->Last)
		{
			printf("warning!!!插入位置会导致空位");
			int new_place;
			scanf("请输入%d\n1:继续插入\n0:取消插入\n2：插入到线性表末尾", &new_place);
			switch (new_place)
			{
			case 0:
				return -1;
			case 1:
				seqList->Data[place] = num;
				return place + 1;
			case 2:
				seqList->Data[seqList->Last] = num;
				seqList->Last++;
				return seqList->Last + 1;
			default:
				break;
			}
		}
		else
		{
			int i = seqList->Last;
			while (i >= place)
			{
				seqList->Data[i + 1] = seqList->Data[i];
				i--;
			}
			seqList->Data[place] = num;
			seqList->Last++;
			return seqList->Last;
		}
	}
}

//删除线性表索引位置place上的元素,成功则返回1，失败则返回0
int DeleteSeqList(SeqList* seqList, int place) {
	if (seqList->Last < place || place < 0)
	{
		printf("设置的删除位置不合法");
		return 0;
	}
	else
	{
		int i = place;
		while (i < seqList->Last)
		{
			seqList->Data[i] = seqList->Data[i + 1];
			i++;
		}
		return 1;
	}
}