#pragma once
#include <malloc.h>
#define MAX_SIZE 100
typedef struct
{
	int Data[MAX_SIZE];
	int Last;
}SeqList;

//��ʼ��һ������ΪLNode�����Ա�,Last��ʾ���һ��Ԫ������λ�õ���һλ
SeqList* InitL() {
	SeqList* L;
	L = (SeqList*)malloc(sizeof(SeqList));
	L->Last = 0;
	return L;
}

//�����Ա��ĩβ����num���ɹ��򷵻����һ��Ԫ������λ�õ���һλ��ʧ���򷵻�-1
int InsertLSeqList(SeqList* seqList, int place, int num) {
	if (seqList->Last == MAX_SIZE)
	{
		printf("��ǰ���Ա�����");
	}
	if (place<0 || place>MAX_SIZE - 1)
	{
		return -1;
		printf("����λ�ò��Ϸ�");
	}
	else
	{
		if (place > seqList->Last)
		{
			printf("warning!!!����λ�ûᵼ�¿�λ");
			int new_place;
			scanf("������%d\n1:��������\n0:ȡ������\n2�����뵽���Ա�ĩβ", &new_place);
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

//ɾ�����Ա�����λ��place�ϵ�Ԫ��,�ɹ��򷵻�1��ʧ���򷵻�0
int DeleteSeqList(SeqList* seqList, int place) {
	if (seqList->Last < place || place < 0)
	{
		printf("���õ�ɾ��λ�ò��Ϸ�");
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