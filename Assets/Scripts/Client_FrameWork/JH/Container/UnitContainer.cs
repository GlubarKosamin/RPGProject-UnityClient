using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitContainer
{
	//�÷��̾ �����ϰ��ִ� ����(����)���� ǥ���ϱ� ���� �����̳�
	public UnitContainer()
	{
		_units = new List<Unit_Data>();
	}

	public static UnitContainer Instance
	{
		get
		{
			if(_instance == null)
				_instance = new UnitContainer();

			return _instance;
		}
		set { _instance = value; }
	}
	private static UnitContainer _instance;

	public static List<Unit_Data> Units
	{
		get { return Instance._units;}
		set { Instance._units = value; }
	}

    private List<Unit_Data> _units { get; set;}
}
