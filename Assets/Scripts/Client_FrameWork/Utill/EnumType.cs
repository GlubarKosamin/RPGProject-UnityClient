using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumType
{
    public enum eGameStatus
    {
        none,
        read_data,
        set_object,
        Loading,
        play,
        suspend,
    }

    //���� ������ �ʿ��� text�� desc_id�� ��Ī���� �ҷ���...
    public enum Desc_Txt
    {

    }

    public enum eGrade
    {
        normal,
        Rare,
        Epic,
        Legend,
    }


    public enum eUnittype
    {
        Combattype,
        supporttype,
        defensivetype,
    }

    public enum eUniteletype
    {
        Fire,
        Water,
        Earth,
        Light,
        darkness,
    }



}
