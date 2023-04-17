using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySytem : MonoBehaviour
{


    EnumTpye.eGameStatus gametype;

    private static GameTableData _instance;
    public static GameTableData Instance
    {
        get
        {
            // ���� _instance�� �������� ���� ��� ���� �����Ѵ�.
            if (_instance == null)
            {
                _instance = new GameTableData();
                //cur_nation_maxunitdata_list = new List<data_maxunit>();
            }
            // _instance�� ��ȯ�Ѵ�.
            return _instance;
        }
    }


    private void Awake()
    {

        GameTableData.Instance.dic_unitdata = CSVReader.Read_Unit_data("Unit_data.csv");
       
        switch (gametype)
        {
            case EnumTpye.eGameStatus.none:
                break;
            case EnumTpye.eGameStatus.read_data:
              
                break;
            case EnumTpye.eGameStatus.set_object:
                break;
            case EnumTpye.eGameStatus.Loading:
                break;
            case EnumTpye.eGameStatus.play:
                break;
            case EnumTpye.eGameStatus.suspend:
                break;
            default:
                break;
        }

    }
}
