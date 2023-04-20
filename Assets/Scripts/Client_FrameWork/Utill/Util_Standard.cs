using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using System.IO;
using UnityEngine.UI;
public static class Util_Standard
{
    public static string StringbuilderUtil(string _txt)
    {
        StringBuilder strBd = new StringBuilder(50);
        strBd.Append(_txt);
        string resultTxt = strBd.ToString();
        strBd.Length = 0;
        return resultTxt;
    }


    //=================================================
    //: ���� Texture ���ҽ� �ε� �� ����...
    //=================================================
    public static Texture Load_Resource_Texture(string _path, string _resName)
    {
        Texture tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        tmp_Result = Resources.Load(_resPath) as Texture;

        //Texture tmp_Result = (Texture)GameObject.Instantiate(tmp_ResultObj);
        return tmp_Result;
    }

    public static Sprite Load_ResourceAsSprite(string _path, string _resName)
    {
        Sprite tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        var obj = Resources.Load(_resPath);

        tmp_Result = Resources.Load<Sprite>(_resPath);

        //Texture tmp_Result = (Texture)GameObject.Instantiate(tmp_ResultObj);
        return tmp_Result;
    }

    //:3d object load
    public static GameObject Load_ResourceAsGameObject(string _path, string _resName)
    {
        GameObject tmp_Result = null;
        string _resPath = _path + "/" + _resName;

        var obj = Resources.Load(_resPath);
        //Debug.LogError("_resName====>"+ _resName);
        tmp_Result = Resources.Load<GameObject>(_resPath);
        GameObject tmp_Resultobj = GameObject.Instantiate(tmp_Result);
        return tmp_Resultobj;
    }


    //resource/icon/�ش� ���ҽ� icon�� �ҷ����� �Լ�
    public static Sprite Load_resource_Unit_Sprites(string _resname)
    {
        //ex) icon_unit_11 <====== ���� ��������Ʈ �����ҋ�...
        string _newresname = StringbuilderUtil("icon_unit_" + _resname);
        Sprite _spr = Load_ResourceAsSprite("Icon", _newresname);
        return _spr;
    }

   
}
