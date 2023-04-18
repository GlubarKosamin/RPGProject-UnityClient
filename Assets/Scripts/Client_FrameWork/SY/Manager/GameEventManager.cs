using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager 
{
    //: Event - ���� ���� �̺�Ʈ
    public delegate void gameStatusEvtHandler(EnumType.eGameStatus _gameStatus);
    public static event gameStatusEvtHandler OnEvent_GameStatus;

    public static void Send_GameStatusEvent(EnumType.eGameStatus _gameStatus)
    {
        OnEvent_GameStatus(_gameStatus);
    }

   

   
}