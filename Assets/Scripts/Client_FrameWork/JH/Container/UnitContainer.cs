using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitContainer
{
	//�÷��̾ �����ϰ��ִ� ����(����)���� ǥ���ϱ� ���� �����̳�
	public UnitContainer()
	{
		Units = new List<Unit_Data>();
	}

    public List<Unit_Data> Units { get; set;}
}
