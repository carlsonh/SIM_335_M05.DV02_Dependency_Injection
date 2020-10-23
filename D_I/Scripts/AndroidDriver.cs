using UnityEngine;
public class AndroidDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("Bike will be AI controlled");
    }
}