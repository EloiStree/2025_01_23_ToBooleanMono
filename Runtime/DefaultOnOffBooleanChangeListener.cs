using UnityEngine.Events;

namespace Eloi.ToBoolean {
    [System.Serializable]
    public class DefaultOnOffBooleanChangeListener : BooleanChangedListener
    {
        public UnityEvent<bool> m_onChanged;
        public BooleanChanged m_onChangedDelegate;
        public UnityEvent m_onChangedTrue;
        public UnityEvent m_onChangedFalse;
        public delegate void BooleanChanged(bool newValue);
        protected override void NotifyChangeToChildren(bool newValue)
        {
            m_onChanged.Invoke(newValue);
            if (m_onChangedDelegate != null)
                m_onChangedDelegate(newValue);
            if (newValue)
                m_onChangedTrue.Invoke();
            else
                m_onChangedFalse.Invoke();
        }
    }
}