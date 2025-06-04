namespace Eloi.ToBoolean {
    [System.Serializable]
    public class DelegateChangedListener : BooleanChangedListener
    {
        BooleanChanged m_onChangedDelegate;
        public delegate void BooleanChanged(bool newValue);
        protected override void NotifyChangeToChildren(bool newValue)
        {
            if (m_onChangedDelegate != null)
                m_onChangedDelegate(newValue);
        }
        public void AddListener(BooleanChanged listener) { m_onChangedDelegate += listener; }
        public void RemoveListener(BooleanChanged listener) { m_onChangedDelegate -= listener; }
    }
}