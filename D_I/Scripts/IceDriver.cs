using UnityEngine;
public class IceDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("Frozen driver's bike falls over. Driver shatters on the ground");
    }
}