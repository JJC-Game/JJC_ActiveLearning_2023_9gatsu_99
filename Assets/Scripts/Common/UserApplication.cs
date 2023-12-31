﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserApplication : MonoBehaviour
{
    private void Awake()
    {
        S = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    static private UserApplication _S;
    static private UserApplication S
    {
        get
        {
            if (_S == null)
            {
                return null;
            }
            return _S;
        }
        set
        {
            if (_S != null)
            {
                Debug.LogError("_Sは既に設定されています.");
            }
            _S = value;
        }
    }

    [Header("UserApplicationからアクセスできるコンポーネント")]
    public FixCharaManager _fixCharaManager;
    static public FixCharaManager fixCharaManager
    {
        get
        {
            if (S._fixCharaManager == null)
            {
                S._fixCharaManager = GameObject.Find("Common").GetComponent<FixCharaManager>();
            }
            return S._fixCharaManager;
        }
    }
    
    public UserDataManager _userDataManager;
    static public UserDataManager userDataManager
    {
        get
        {
            if (S._userDataManager == null)
            {
                S._userDataManager = GameObject.Find("UserDataManager").GetComponent<UserDataManager>();
            }
            return S._userDataManager;
        }
    }

    public CharaGridRenderer _charaGridRenderer;
    static public CharaGridRenderer charaGridRenderer
    {
        get
        {
            if (S._charaGridRenderer == null)
            {
                S._charaGridRenderer = GameObject.Find("UIParts_CharaGridRenderer").GetComponent<CharaGridRenderer>();
            }
            return S._charaGridRenderer;
        }
    }

    public PHPConnectManager _phpConnectManager;
    static public PHPConnectManager phpConnectManager
    {
        get
        {
            if (S._phpConnectManager == null)
            {
                S._phpConnectManager = GameObject.Find("PHPConnectManager").GetComponent<PHPConnectManager>();
            }
            return S._phpConnectManager;
        }
    }

    public P3_UserDataManager _p3_userDataManager;
    static public P3_UserDataManager p3_userDataManager
    {
        get
        {
            if (S._p3_userDataManager == null)
            {
                S._p3_userDataManager = GameObject.Find("UserDataManager").GetComponent<P3_UserDataManager>();
            }
            return S._p3_userDataManager;
        }
    }

    public ItemListRenderer _itemListRenderer;
    static public ItemListRenderer itemListRenderer
    {
        get
        {
            if (S._itemListRenderer == null)
            {
                S._itemListRenderer = GameObject.Find("UIParts_ItemList").GetComponent<ItemListRenderer>();
            }
            return S._itemListRenderer;
        }
    }

    public P4_UserDataManager _p4_userDataManager;
    static public P4_UserDataManager p4_userDataManager
    {
        get
        {
            if (S._p4_userDataManager == null)
            {
                S._p4_userDataManager = GameObject.Find("UserDataManager").GetComponent<P4_UserDataManager>();
            }
            return S._p4_userDataManager;
        }
    }
    
    public FixItemManager _fixItemManager;
    static public FixItemManager fixItemManager
    {
        get
        {
            if (S._fixItemManager == null)
            {
                S._fixItemManager = GameObject.Find("Common").GetComponent<FixItemManager>();
            }
            return S._fixItemManager;
        }
    }

    public P4_PHPConnectManager _p4_phpConnectManager;
    static public P4_PHPConnectManager p4_phpConnectManager
    {
        get
        {
            if (S._p4_phpConnectManager == null)
            {
                S._p4_phpConnectManager = GameObject.Find("PHPConnectManager").GetComponent<P4_PHPConnectManager>();
            }
            return S._p4_phpConnectManager;
        }
    }    
}
