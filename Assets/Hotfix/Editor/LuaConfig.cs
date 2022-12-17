using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System.Reflection;
using System.Linq;
using Apotocalypto_Framework;

public static class LuaConfig
{
    [LuaCallCSharp]
    public static List<Type> module_lua_call_cs_list = new List<Type>()
    {
        typeof(GameObject),
        typeof(Dictionary<string, int>),
        typeof(OnValueChanged<int>)
    };


    [Hotfix]
    static IEnumerable<Type> HotfixInject
    {
        get
        {
            return (from type in Assembly.Load("Assembly-CSharp").GetTypes()
                    where type.Namespace == null || !type.Namespace.StartsWith("XLua")
                    select type);
        }
    }


}