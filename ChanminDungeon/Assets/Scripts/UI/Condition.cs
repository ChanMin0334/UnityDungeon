using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;
    public float startValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar;

    void Start()
    {
        curValue = startValue;
    }

    // Update is called once per frame
    void Update()
    {
        uiBar.fillAmount = GetPercent();
    }

    float GetPercent()
    {
        return curValue / maxValue;
    }
    public void AddValue(float value)
    {
        curValue += value;
        if (curValue > maxValue)
        {
            curValue = maxValue;
        }
    }

    public void SubValue(float value)
    {
        curValue -= value;
        if (curValue < 0)
        {
            curValue = 0;
        }
    }
}
