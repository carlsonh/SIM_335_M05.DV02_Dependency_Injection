using UnityEngine;
public class FireEngine : IEngine
{
    public void StartEngine()
    {
        LightTinder();
        Debug.Log("Engine Started");
    }

    private void LightTinder()
    {
        Debug.Log("Tinder lighted");
    }
}