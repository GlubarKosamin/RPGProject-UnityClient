using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Client_FrameWork.UI;

namespace Client_FrameWork.Controller
{
    public class UnitController : MonoBehaviour
    {
        //GameTableData�� ����� ���������� ������
        //UnitContainer�� ������ ����ϰ� �����ϴ� ����.

        [SerializeField] private ScrollViewSlots _Unitslots;


        public void RegisterUnit(int id)
        {
            UnitContainer.Units.Add(GameTableData.Instance.dic_unitdata[id]);

            List<BaseData> unitDataList = UnitContainer.Units.ConvertAll<BaseData>(data => data as BaseData);
            _Unitslots.UpdateData(unitDataList);
        }
        public void RegisterUnit(Unit_Data unit)
		{
            UnitContainer.Units.Add(unit);
		}

        public void RemoveUnit()
		{
            //remove unit
		}
	}
}

