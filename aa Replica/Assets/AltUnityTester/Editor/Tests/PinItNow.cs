using System.Collections.Generic;
using UnityEngine;
using Altom.AltUnityDriver;
using NUnit.Framework;
using UnityEngine.UI;
public class PinItNow
{
   // public static AltUnityDriver Driver;
/*
    /// <summary>
    /// SetUp
    /// </summary>
    [OneTimeSetUp]
    public void SetUp()
    { 
        Driver = new AltUnityDriver();
    }


    /// <summary>
    /// Verify Camera is present in the scene
    /// </summary>
    [Test, Order(1)]
    public void verifyCameraisPresent()
    {
        AltUnityObject mycamera = Driver.FindObject(By.NAME,("Main Camera"));
        Assert.NotNull(mycamera);
    }

    /// <summary>
    /// Click Screen
    /// </summary>
    [Test, Order(2)]
    public void clickScreenToShoot()
    {
        AltUnityObject shootPin = Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
    }

    /// <summary>
    /// Stop 
    /// </summary>
    [OneTimeTearDown]
    public void bitdi()
    {
        Driver.Stop();
    }
*/













    /*   [Test, Order(1)]
   public void VerifyScoreIncreaseWhenPinTouch()
   {
       Driver.WaitForCurrentSceneToBe("MainLevel");
       AltUnityObject PinSpawnObj = Driver.FindObjectByName("PinSpawnPoint"); //PinSpawnpoint Object
       AltUnityVector2 ballMotherhoodLocation = PinSpawnObj.getScreenPosition();
       AltUnityObject ScoreObject = Driver.FindObjectByPath( "//Canvas/Score");
       int currentScore = int.Parse(ScoreObject.GetText()); //Getting text of 
       Driver.Tap(ballMotherhoodLocation); //tapping pin spawn point to shoot
       int afterTapScore =int.Parse(Driver.WaitForObjectByPath("//Canvas/Score[@text=" + (currentScore + 1).ToString() + "]").GetText());
       Assert.AreEqual(currentScore+1, afterTapScore);
   }
*/

    /*
    [Test,Order(3)]
    public void verifyPinStickedToRotator()
    {
        AltUnityObject rotatorChild = Driver.WaitForObjectToHaveChildrenByName("Rotator");
        Assert.NotNull(rotatorChild);
    }


    [Test, Order(4)]
    public void verifyRotatorPosition()
    {
        //our rotator object
        AltUnityObject RotatorObj = Driver.WaitForObjectByName("Rotator");
        //first component of our object (UnityEngine.Transform) 
        AltUnityComponent transfromComponent = RotatorObj.GetAllComponents()[0];
        //first property of our transform component
        AltUnityProperty positionProperty = RotatorObj.GetAllProperties(transfromComponent)[0];
        // get value of that property like (0.00, 4.64, 23.4) pure value with parenthesis
        string positionPropertyPureValue = positionProperty.value;
        // trim parenthesis
        positionPropertyPureValue = positionPropertyPureValue.Trim('(',')');
        //since position field has 3 variables take them without , sign 
        List<string> positionPropertyValues = new List<string>(positionPropertyPureValue.Split(',', 3));
        Assert.AreEqual(0.00f, positionPropertyValues[0]);
        Assert.AreEqual(3.31f, positionPropertyValues[1]);
        Assert.AreEqual(0.00f, positionPropertyValues[2]);
    }

    [Test,Order(5)]
    public void verifyRotatorHasAnimatorComponents()
    {

        AltUnityObject rotatorObj = Driver.FindObjectByComponent("Rotator");
        AltUnityComponent anime =   rotatorObj.GetComponentByFullName("UnitykEngine.Anlimator");
        Debug.LogWarning("FULL COMPONENT NAME ISHOYOYOYO: " + anime.componentName);


    }

    [Test,Order(6)]
    public void verifySlideObjectValueisZeroOnGameBeginning()
    {


        AltUnityObject sliderObj = Driver.FindObjectByName("Slider");
        AltUnityComponent sliderComponent = sliderObj.GetComponentByFullName("UnityEngine.UI.Slider");
        var a = sliderObj.GetComponentProperty<float>(sliderComponent, "value");
        // var a = sliderObj.GetComponentProperty<float>("UnityEngine.UI.Slider", "value");


        //property names
        *//*for (int i = 0; i < sliderObj.GetAllProperties(sliderComponent).Count; i++)
        {
            Debug.LogWarning("YOUR COMPONENT PROPERTIES IS | "+sliderObj.GetAllProperties(sliderComponent)[i].name);
        }*//*
        //component names
        *//*List<AltUnityComponent> slideComponents =  sliderObj.GetAllComponents();
        for (int i = 0; i < slideComponents.Count; i++)
        {
           Debug.LogWarning("YOUR SLIDE gamobject components NAME IS: "+slideComponents[i].componentName);
        }*//*
    }

    [Test,Order(6)]
    public void swipeSliderToRightAndAssertValueHasIncreased()
    { 
        //swipe slider
        AltUnityObject fillObject = Driver.WaitForObjectByName("Fill");
        AltUnityVector2 screenpositionXY = fillObject.getScreenPosition();
        AltUnityVector3 worldPositionXYZ = fillObject.getWorldPosition();
        Driver.Swipe(screenpositionXY,new AltUnityVector2(screenpositionXY.y, screenpositionXY.x+30));
        //assert value increased
        AltUnityObject sliderObj = Driver.FindObjectByName("Slider");
        AltUnityComponent sliderComponent = sliderObj.GetComponentByFullName("UnityEngine.UI.Slider");
        var a = sliderObj.GetComponentProperty<float>(sliderComponent, "value");
        Assert.AreEqual(1f, a);

    }

    [Test,Order(7)]
    public void takescreenshot()
    {
        //Driver.GetPNGScreenshot("Assets/AltUnityTester/Editor/Tests");
        Driver.GetPNGScreenshot("C:/Users/resha/Documents/GitHub/aa-Replica/aa Replica/Assets/AltUnityTester/Editor/Tests/canm.png");
        //Driver.GetPNGScreenshot("/hello.png");

    }*/

}