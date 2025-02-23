using UnityEngine;

public class ToBoolMono_IsMonoScriptEnabled : AbstractToBooleanMono
{
    public MonoBehaviour m_monoScript;
    public bool m_inverse = false;

    public override bool CheckCondition()
    {
        if (m_inverse)
        {
            return !m_monoScript.enabled;
        }
        return m_monoScript.enabled;
    }
}
