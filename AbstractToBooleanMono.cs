using System;
using UnityEngine;
using UnityEngine.Events;


public abstract class AbstractToBooleanMono : MonoBehaviour
{
    public bool m_currentIsInCondition;
    public bool m_previousIsInCondition;
    public UnityEvent m_onIsTrueChanged;
    public UnityEvent m_onIsFalseChanged;
    public UnityEvent<bool> m_onValueChanged;
    public UnityEvent<bool> m_onValueChecked;

    public bool m_useUpdate=true;

    public void Update()
    {
        if (m_useUpdate)
        {
            CheckCurrentConditionState();
        }
    }

    [ContextMenu("Check Condition")]
    public void CheckCurrentConditionState() { 
    
        m_previousIsInCondition = m_currentIsInCondition;
        m_currentIsInCondition = CheckCondition();
        m_onValueChecked.Invoke(m_currentIsInCondition);
        if (m_currentIsInCondition != m_previousIsInCondition)
        {
            if (m_currentIsInCondition)
            {
                m_onIsTrueChanged.Invoke();
            }
            else
            {
                m_onIsFalseChanged.Invoke();
            }
            m_onValueChanged.Invoke(m_currentIsInCondition);
        }
    }
    public abstract bool CheckCondition();
}
