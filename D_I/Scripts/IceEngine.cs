using UnityEngine;
public class IceEngine : IEngine
{
    public void StartEngine()
    {
        FreezeWater();
        Debug.Log("Engine Started");
    }

    private void FreezeWater()
    {
        Debug.Log("Water Frozen!");
    }
}