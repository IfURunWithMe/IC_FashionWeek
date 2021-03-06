﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 本地数据类
/// </summary>
public class ZPlayerMe
{

    private static ZPlayerMe m_Instance;
    public static ZPlayerMe Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new ZPlayerMe();
            }
            return m_Instance;
        }
    }

    /// <summary>
    /// 玩家数据 key=playerId value=实体
    /// </summary>
    public Dictionary<string, Entity> PlayerMap = new Dictionary<string, Entity>();
    public List<string> PlayerKeys = new List<string>();
    

    public void AddPlayer(string playerId, Entity en)
    {
        Entity outEn;
        if(!PlayerMap.TryGetValue(playerId, out outEn))
        {
            PlayerMap[playerId] = en;
        }
        else
        {
            Debug.Log("eero");
        }
    }

    public void RemovePlayer(string playerId)
    {
        Entity en;
        if(PlayerMap.TryGetValue(playerId, out en))
        {
            PlayerMap.Remove(playerId);
        }
        else
        {
            
        }
    }
}
