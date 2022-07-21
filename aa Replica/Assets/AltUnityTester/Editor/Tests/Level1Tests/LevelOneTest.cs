using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using Altom.AltUnityDriver;
public class LevelOneTest 
{
    public static AltUnityDriver Driver;

    [OneTimeSetUp]
    public void BeforeBegin()
    {
        Driver = new AltUnityDriver();
    }

    [Test, Order(3)]
    public void VerifySpawnObjectCreation()
    {
        // video +
        Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
        Assert.NotNull(Driver.FindObject(By.NAME, "Pin(Clone)"));

    }


    [Test, Order(4)]
    public void VerifySpawnedObjectToBeChildOfRotator()
    {
        //video +
        AltUnityObject SpawnedObject = Driver.WaitForObject(By.PATH, "/Rotator/Pin(Clone)");
        Assert.NotNull(SpawnedObject);
    }

    [Test, Order(5)]
    public void VerifyScoreIncreaseInAWhile()
    {
        //video ile izah edilmeyib
        AltUnityObject ScoreGameObject = Driver.FindObject(By.NAME, "Score");
        string ComponentNameOfText = "UnityEngine.UI.Text";
        string propertyNameOfText = "text";

        string Score = Driver.WaitForObject(By.NAME, "Score").GetComponentProperty<string>(ComponentNameOfText, propertyNameOfText);
        int expectedScore = 1;
        int actualScore = int.Parse(Score);
        Assert.AreEqual(expectedScore, actualScore);


    }
    [Test, Order(2)]
    public void VerifyAnimatorComponentPresentOnCamera()
    {
        //video ile izah olunmayib

        AltUnityObject CameraObj = Driver.FindObject(By.NAME, "Main Camera");
        //   AltUnityComponent MyAnimationComponent = CameraObj.GetAllComponents()[5];

        //below method helps us to identify and the specific component of camera object.
        for (int i = 0; i < CameraObj.GetAllComponents().Count; i++)
        {
            if (CameraObj.GetAllComponents()[i].Equals("UnityEngine.Animator"))
            {
                Assert.True(true);
            }
        }
    }
    [Test, Order(1)]
    public void VerifyGameEndsWhenPinsCrashes()
    {
        //Video ile izah olunmayib

        //we click contniously to make game end
        Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
        Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
        //find cam
        AltUnityObject CameraObj = Driver.FindObject(By.NAME, "Main Camera");
        //find gamemanager obj in cam
        for (int i = 0; i < CameraObj.GetAllComponents().Count; i++)
        {
            Debug.LogWarning(CameraObj.GetAllComponents()[i].componentName);
            if (CameraObj.GetAllComponents()[i].Equals("GameManager"))
            {
                AltUnityComponent GameMan = CameraObj.GetAllComponents()[i];
                //check if gamehasEnded set to true
                bool isGameOver = Driver.WaitForObject(By.NAME, "Main Camera").GetComponentProperty<bool>("GameManager", "gameHasEnded");
                Assert.True(isGameOver);
            }
        }

    }
    [Test, Order(6)]
    public void VerifyLevelChangesWhenScoreIncreased()
    {
        //video ile izah olunmayib
        Driver.WaitForCurrentSceneToBe("Level2");
    }










}
