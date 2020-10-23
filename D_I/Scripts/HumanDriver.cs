using UnityEngine;

public class HumanDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("Human bike driver");
    }
}