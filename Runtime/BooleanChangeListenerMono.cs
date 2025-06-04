using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.ToBoolean { 

    [System.Serializable]
    public class BooleanStateChangedObserver
    {

        [SerializeField] bool m_booleanState;
        public void SetBoolean(in bool value, out bool changed)
        {
            changed = value != m_booleanState;
            m_booleanState = value;
        }
        public void GetBoolean(out bool value) => value = m_booleanState;
        public bool GetBoolean()
        {
            return m_booleanState;
        }
    }
}