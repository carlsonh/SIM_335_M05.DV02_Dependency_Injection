using UnityEngine;
public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine Started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("Nitro valve opened");
    }
}