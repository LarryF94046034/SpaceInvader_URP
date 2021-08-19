using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface TCharacterFactory_Generic 
{
    //建立Sodier(Generic版)
    ISoldier CreateSoldier<T>(ENUM_Weapon eNUM_Weapon,int Lv,Vector3 SpawnPosition) where T:ISoldier,new();
}
