using UnityEngine;

namespace Eloi.ToBoolean {
    [System.Serializable]
    public abstract class BooleanChangedListener
    {
        [SerializeField] BooleanStateChangedObserver m_observer = new BooleanStateChangedObserver();

        public void SetBoolean(in bool value)
        {
            SetBoolean(in value, out bool tmp);
        }
        public void SetBoolean(in bool value, out bool changed)
        {
            m_observer.SetBoolean(in value, out changed);
            if (changed)
            {
                NotifyChangeToChildren(value);
            }
        }
        protected abstract void NotifyChangeToChildren(bool newValue);

        public void GetBoolean(out bool value) => m_observer.GetBoolean(out value);
        public bool GetBoolean()
        {
            return m_observer.GetBoolean();
        }

    }
}