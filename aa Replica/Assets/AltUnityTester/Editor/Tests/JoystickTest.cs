using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using Altom.AltUnityDriver;
using NUnit.Framework;
using UnityEngine.UI;
using Assets.AltUnityTester.Editor.Tests;
public class JoystickTest 
{
    public AltUnityDriver Driver;
    [OneTimeSetUp]
    public void SetUp()
    {

       Driver = new AltUnityDriver();
       
    }

    [Test]
    public void loadJoystickScene()
    {
        
        Driver.LoadScene("Example Scene");
        Driver.WaitForCurrentSceneToBe("Example Scene");
    }

    [Test]
    public void pressIt()
    {
        //get ball position when starts
        AltUnityObject player = Driver.FindObjectByName("Player");
    //    AltUnityVector3 playerPosition = player.getWorldPosition();
        AltUnityComponent tranformPlayer = player.GetComponentByFullName("UnityEngine.Transform");
        var playerposition = player.GetComponentProperty<mydata>(tranformPlayer, "position");

        Debug.LogWarning("Player position before: x " + playerposition.x + " y " + playerposition.y + " z " + playerposition.z);
        //move joystick
        AltUnityObject joystickCore = Driver.FindObjectByPath("//Variable Joystick/Background/Handle");
        AltUnityObject joystickBackground = Driver.FindObjectByPath("//Variable Joystick/Background");
       // Debug.LogWarning("joystick name is : " + joystickCore.name);
        //Debug.LogWarning("Background name is : " + joystickBackground.name);
       // Debug.LogWarning("joystick vector x: " + joystickCore.getScreenPosition().x + "y: " + joystickCore.getScreenPosition().y);
        Debug.LogWarning("Background vector x : " + joystickBackground.getScreenPosition().x + " y: " + joystickBackground.getScreenPosition().y);
        AltUnityVector2 joystickCoreVector = joystickCore.getScreenPosition();
        AltUnityVector2 joystickBackgroundVector = joystickBackground.getScreenPosition();
        int fingerid = Driver.BeginTouch(joystickCoreVector);
       
        Driver.MoveTouch(fingerid, new AltUnityVector2(joystickCoreVector.x, 250));
        while (true)
        {
            var playerposition2 = player.GetComponentProperty<mydata>(tranformPlayer, "position");
            if (playerposition2.z > 2)
            {
                Debug.LogWarning("Player position after: x " + playerposition2.x + " y " + playerposition2.y + " z " + playerposition2.z);

            }
        }
        //check if ball moved




    }


}
