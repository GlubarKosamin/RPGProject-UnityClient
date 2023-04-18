using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySytem : MonoBehaviour
{
    private static GamePlaySytem _instance;
    public static GamePlaySytem Instance
    {
        get
        {
            // ���� _instance�� �������� ���� ��� ���� �����Ѵ�.
            if (_instance == null)
            {
                _instance = new GamePlaySytem();
                //cur_nation_maxunitdata_list = new List<data_maxunit>();
            }
            // _instance�� ��ȯ�Ѵ�.
            return _instance;
        }
    }

    EnumType.eGameStatus gametype;

    private void Awake()
    {
        GameTableData.Instance.dic_unitdata = CSVReader.Read_Unit_data("Unit_data.csv");

        switch (gametype)
        {
            case EnumType.eGameStatus.none:
                break;
            case EnumType.eGameStatus.read_data:
              
                break;
            case EnumType.eGameStatus.set_object:
                break;
            case EnumType.eGameStatus.Loading:
                break;
            case EnumType.eGameStatus.play:
                break;
            case EnumType.eGameStatus.suspend:
                break;
            default:
                break;
        }

    }
}
