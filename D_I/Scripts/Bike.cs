using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    private IEngine m_Engine;
    private IDriver m_Driver; //CS0051, must be public


    //Setter injection
    public void SetEngine(IEngine engine) => m_Engine = engine;
    public void SetDriver(IDriver driver) => m_Driver = driver;

    public void StartEngine()
    {
        //Starting eng
        m_Engine.StartEngine();

        m_Driver.Control(this);
    }

    public void TurnLeft()
    {
        Debug.Log("Bike turning left");
    }
    public void TurnRight()
    {
        Debug.Log("Bike turning right");
    }

}

