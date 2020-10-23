using System;
using UnityEngine;

public class Client : MonoBehaviour
{
    //Player bike
    public Bike m_PlayerBike;

    //AI controlled bike
    public Bike m_AndroidBike;
    public Bike m_IceBike;
    public Bike m_FireBike;


    private void Awake()
    {
        m_FireBike = new Bike();
        m_IceBike = new Bike();

        m_PlayerBike = new Bike();
        m_AndroidBike = new Bike();

        //setup Fire w/fire engine
        IEngine fireEngine = new FireEngine();
        IDriver fireDriver = new FireDriver();

        m_FireBike.SetEngine(fireEngine);
        m_FireBike.SetDriver(fireDriver);
        m_FireBike.StartEngine();

        //Setup ice w/ice engine
        IEngine iceEngine = new IceEngine();
        IDriver iceDriver = new IceDriver();

        m_IceBike.SetEngine(iceEngine);
        m_IceBike.SetDriver(iceDriver);
        m_IceBike.StartEngine();


        //Setup human w/jet engine
        IEngine jetEngine = new JetEngine();
        IDriver humanDriver = new HumanDriver();

        m_PlayerBike.SetEngine(jetEngine);
        m_PlayerBike.SetDriver(humanDriver);
        m_PlayerBike.StartEngine();

        //Set up AI w/nitro eng
        IEngine nitroEngine = new NitroEngine();
        IDriver androidDriver = new AndroidDriver();

        m_AndroidBike.SetEngine(nitroEngine);
        m_AndroidBike.SetDriver(androidDriver);
        m_AndroidBike.StartEngine();
    }

    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            m_PlayerBike.TurnLeft();
        }
        if (Input.GetKeyDown("d"))
        {
            m_PlayerBike.TurnRight();
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
        GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
    }
}