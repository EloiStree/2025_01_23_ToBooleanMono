using UnityEngine.Events;

namespace Eloi.ToBoolean {
    [System.Serializable]
    public class DefaultBooleanChangeListener : BooleanChangedListener
    {
        public UnityEvent<bool> m_onChanged;
        public BooleanChanged m_onChangedDelegate;
        public delegate void BooleanChanged(bool newValue);
        protected override void NotifyChangeToChildren(bool newValue)
        {
            m_onChanged.Invoke(newValue);
            if (m_onChangedDelegate != null)
                m_onChangedDelegate(newValue);
        }
    }
}