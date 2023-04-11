using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//: �ۼ��� :sy
//: csv�� data�� �̰��� ������ ������ ���� ��Ƶδ� Ŭ����...
public class GameTableData
{
    public Dictionary<int, Unit_Data> dic_Unit;


    private static GameTableData _instance;
    public static GameTableData Instance
    {
        get
        {
            // ���� _instance�� �������� ���� ��� ���� �����Ѵ�.
            if (_instance == null)
            {
                _instance = new GameTableData();
            }
            // _instance�� ��ȯ�Ѵ�.
            return _instance;
        }
    }
}
