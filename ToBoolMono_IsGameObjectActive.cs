using UnityEngine;

public class ToBoolMono_IsGameObjectActive : AbstractToBooleanMono
{
    public GameObject m_gameObject;
    public bool m_inverse = false;

    public override bool CheckCondition()
    {
        if (m_inverse)
        {
            return !m_gameObject.activeSelf;
        }
        return m_gameObject.activeSelf;
    }
}
