using UnityEngine;
public class FireDriver : IDriver
{
    private Bike m_Bike;

    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("Fire driver burns up, bike sits empty.");
    }
}