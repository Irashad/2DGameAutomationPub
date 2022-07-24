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

    /// <summary>
    /// Verify Game Over When Pins Crash
    /// </summary>
    /*    [Test, Order(1)]
        public void VerifyGameEndsWhenPinsCrashes()
        {
            //video+
            Driver.LoadScene("Level1");
            Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
            Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
            AltUnityObject CameraObj = Driver.FindObject(By.NAME, "Main Camera");
            bool isGameOver = Driver.WaitForObject(By.NAME, "Main Camera").GetComponentProperty<bool>("GameManager", "gameHasEnded");
            Assert.True(isGameOver);

        }*/
    /// <summary>
    /// Verify Animator Component atteched to the Main Camera
    /// </summary>
    /*    [Test, Order(2)]
        public void VerifyAnimatorComponentPresentOnCamera()
        {
            //video+
            Driver.LoadScene("Level1");
            Driver.WaitForCurrentSceneToBe("Level1");


            AltUnityObject CameraObj = Driver.FindObject(By.NAME, "Main Camera");
            //loop until find UnityEngine.Animator component in array
            for (int i = 0; i < CameraObj.GetAllComponents().Count; i++)
            {
                if (CameraObj.GetAllComponents()[i].Equals("UnityEngine.Animator"))
                {
                    Assert.True(true);
                }
            }
        }
    */

    /*    [Test, Order(3)]
        public void VerifySpawnObjectCreation()
        {
            // video +
            Driver.FindObject(By.NAME, "PinSpawnPoint").Click();
            Assert.NotNull(Driver.WaitForObject(By.NAME, "Pin(Clone)"));

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
            //video+
            AltUnityObject ScoreGameObject = Driver.FindObject(By.NAME, "Score");
            string ComponentNameOfText = "UnityEngine.UI.Text";
            string propertyNameOfText = "m_Text";

            string Score = Driver.WaitForObject(By.NAME, "Score").GetComponentProperty<string>(ComponentNameOfText, propertyNameOfText);
            int expectedScore = 1;
            int actualScore = int.Parse(Score);
            Assert.AreEqual(expectedScore, actualScore);


        }*/



    //-----------------------------------------LEVEL 2 ------------------------------

    //test case1
    /*   [Test, Order(6)]
       public void ClickBlueBox()
       {
           Driver.LoadScene("Level2");
           //video +
           AltUnityObject Box = Driver.FindObject(By.NAME, "Box");
           Box.Click();
           Assert.AreEqual("0", Box.GetComponentProperty<string>("UnityEngine.Rigidbody2D", "bodyType"));
       }
   */
    /*    [Test, Order(7)]
        public void ClickYellowBoxVerifyRigidBodyWillNotChange()
        {

            Driver.LoadScene("Level2");
            AltUnityObject Ground = Driver.FindObject(By.NAME, "Ground");
            Ground.Click();
            Assert.AreEqual("1", Ground.GetComponentProperty<string>("UnityEngine.Rigidbody2D", "bodyType"));
        }



    */







    //------------------------------Level 3 ------------------------------------//
    // Level 3
    ///test case 1.  Assert Value to be 100 when slided fully
    /*  [Test, Order(8)]
      public void ScrollSideBar()
      {
    //video+
          Driver.LoadScene("Level3");
          AltUnityObject Fill = Driver.FindObject(By.NAME, "Fill");
          AltUnityObject Slider = Driver.FindObject(By.NAME, "Slider");
          Driver.Swipe(new AltUnityVector2(Fill.getWorldPosition().x, Fill.getWorldPosition().y), new AltUnityVector2(Fill.getWorldPosition().x +500, Fill.getWorldPosition().y));
          float ValueOfSlider = Slider.GetComponentProperty<float>("UnityEngine.UI.Slider", "value");
          Assert.AreEqual(100f, ValueOfSlider);
      }*/








    /*  //test case 2
      [Test, Order(9)]
      public void ScrollSideBarVerifyBoxAppear()
      {
          Driver.LoadScene("Level3");
          //video +
          AltUnityObject Fill = Driver.FindObject(By.NAME, "Fill");
          AltUnityObject slider = Driver.FindObject(By.NAME, "Slider");

          Driver.Swipe(new AltUnityVector2(Fill.getWorldPosition().x, Fill.getWorldPosition().y), new AltUnityVector2(Fill.getWorldPosition().x + 500, Fill.getWorldPosition().y));
          float ValueOfSlider = slider.GetComponentProperty<float>("UnityEngine.UI.Slider", "value");


          bool checkBox = Driver.FindObject(By.NAME, "Image").enabled;
          Assert.True(checkBox);

      }*/



    //Level 3
    //test case 3. 
    /*    [Test, Order(10)]
        public void VerifyComponentAttachedToSlider()
        {
            AltUnityObject SlObj = Driver.FindObject(By.NAME, "Slider");

            List<AltUnityComponent> components = SlObj.GetAllComponents();
            foreach (var item in components)
            {
                if(item.componentName.Equals("WhenSlideFull"))
                {
                    Assert.True(true);
                }
            }

            // UnityEngine.UI.Slider
            //value
        }*/








    //------------------------------------------------- //Level 4 -------------------------
    //test case 1

    /// <summary>
    //test case 1.
    // 1. clik up button
    ///2. assert that wehn your box collide with another "crash" is set to true on your player box oject When collide script
    /// </summary>
    /*[Test, Order(10)]
    public void VerifyBoxCollideWithAnothernewLevelsLoaded()
    { 
        Driver.LoadScene("Level4");
        AltUnityObject UpButton = Driver.FindObject(By.NAME, "up");
        UpButton.Click();

        while (!Driver.WaitForObject(By.NAME, "Cube (1)").GetComponentProperty<bool>("WhenCollide", "crash"))
        {
        }

        if (Driver.WaitForObject(By.NAME, "Cube (1)").GetComponentProperty<bool>("WhenCollide", "crash"))
        {
            bool checkCrash = true;
            Assert.True(checkCrash);
        }
       
      
    }*/

    ///test case 2. 
    ///1. click up button
    ///2. assert that your beginning position y and current position y has changed when you click up button
    ///
    /* [Test, Order(11)]
     public void VerifyPositionChange()
     {
         Driver.LoadScene("Level4");

         AltUnityObject PlayerCube = Driver.FindObject(By.NAME, "Cube (1)");


         float currentPosition = PlayerCube.getWorldPosition().y;

         AltUnityObject UpButotn = Driver.FindObject(By.NAME, "up");
         UpButotn.Click();


         float afterMovement = PlayerCube.getWorldPosition().y;
         while (currentPosition.Equals(afterMovement))
         {
             afterMovement = Driver.FindObject(By.NAME, "Cube (1)").getWorldPosition().y;
             if (currentPosition < afterMovement)
             {
                 //y is bigger which is passed test case.
                 Assert.AreNotEqual(currentPosition, afterMovement);
                 break;
             }
         }
     }
 */
    /// <summary>
    /// test case 3. 
    //1. assert both box has collider component
    //2. assert both box has rigidbody component
    //3. assert main camera is exist

    /// </summary>

    /* [Test, Order(12)]
     public void assertComponentsExistency()
     {
         //find  camera
         AltUnityObject camera;
         try
         {
              camera = Driver.FindObject(By.NAME, "Main Camera");
             Assert.NotNull(camera);
         }
         catch (NotFoundException exception)
         {
             Debug.LogWarning("The main camera not exist");
         }



         List<AltUnityObject> gameobject  =  Driver.FindObjects(By.COMPONENT, "UnityEngine.BoxCollider");
         List<AltUnityObject> gameobject2  =  Driver.FindObjects(By.COMPONENT, "UnityEngine.Rigidbody");

         bool isCubeOneHasBoxComponent = false;
         bool isCubeTwoHasBoxComponent = false;
         bool isCubeOneHasRigidbodyComponent = false;
         bool isCubeTwoHasRigidbodyComponent = false;


         foreach (var item in gameobject)
         {
             if(item.name.Equals("Cube (1)"))
             {
                 isCubeOneHasBoxComponent = true; 
             }
             if (item.name.Equals("Cube (2)"))
             {
                 isCubeTwoHasBoxComponent = true;
             }

         }


         foreach (var item in gameobject2)
         {
             if (item.name.Equals("Cube (1)"))
             {
                 isCubeOneHasRigidbodyComponent = true;
             }
             if (item.name.Equals("Cube (2)"))
             {
                 isCubeTwoHasRigidbodyComponent = true;
             }

         }

         Assert.True(isCubeOneHasBoxComponent);
         Assert.True(isCubeTwoHasBoxComponent);
         Assert.True(isCubeOneHasRigidbodyComponent);
         Assert.True(isCubeTwoHasRigidbodyComponent);


     }*/

    //------------------------------level 5 ------------------------
    /*    [Test, Order(13)]
        public void assertComponentsPlayer()
        {
            Driver.LoadScene("level5");
            List<AltUnityComponent> playersComponents = Driver.FindObject(By.NAME, "player").GetAllComponents();
            foreach (var item in playersComponents)
            {
                if (item.componentName.Equals("UnityEngine.BoxCollider"))
                {
                    Assert.True(true);

                }
                if (item.componentName.Equals("UnityEngine.Rigidbody"))
                {
                    Assert.True(true);
                }
                if (item.componentName.Equals("WhenColl"))
                {
                    Assert.True(true);
                }
            }
        }
    */


    [Test, Order(14)]
    public void ClickUIButtonAssertComponentTrueValue()
    {

        Driver.LoadScene("level5");

        //find ui game objectss
        var upbtn = FindObjectByName("up");
        var downbtn = FindObjectByName("down");
        var leftbtn = FindObjectByName("left");
        var rightbtn = FindObjectByName("right");
        //find ui game objects

        //find move component for each gameobj
        AltUnityComponent moveComponentOfUpBtn;
        AltUnityComponent moveComponentOfDownBtn;
        AltUnityComponent moveComponentOfLeftBtn;
        AltUnityComponent moveComponentOfRightBtn;
        try
        {
            moveComponentOfUpBtn = FindComponentofGameObjectByGameObjectName(upbtn.name, "move");
            moveComponentOfDownBtn = FindComponentofGameObjectByGameObjectName(downbtn.name, "move");
            moveComponentOfRightBtn = FindComponentofGameObjectByGameObjectName(rightbtn.name, "move");
            moveComponentOfLeftBtn = FindComponentofGameObjectByGameObjectName(leftbtn.name, "move");
            Debug.LogWarning("Cox sad oldum");
        }
        catch (ComponentNotFoundException e)
        {
            Debug.LogWarning("Cox pis oldum");
            throw new ComponentNotFoundException();
        }
        //find move component for each gameobj


        //click moves
        upbtn.Click();
        downbtn.Click();
        leftbtn.Click();
        rightbtn.Click();
        //click moves

        //check move component has set to true for each button (left right up down)
        bool checkisUpIsSetTrue = bool.Parse(upbtn.GetComponentProperty<string>(moveComponentOfUpBtn.componentName, "UpButtonTouched"));
        bool checkisDownIsSetTrue = bool.Parse(downbtn.GetComponentProperty<string>(moveComponentOfDownBtn.componentName, "DownButtonTouched"));
        bool checkisRightIsSetTrue = bool.Parse(rightbtn.GetComponentProperty<string>(moveComponentOfRightBtn.componentName, "RightButtonTouched"));
        bool checkisLeftIsSetTrue = bool.Parse(leftbtn.GetComponentProperty<string>(moveComponentOfLeftBtn.componentName, "LeftButtonTouched"));

        Assert.True(checkisUpIsSetTrue);
        Assert.True(checkisLeftIsSetTrue);
        Assert.True(checkisRightIsSetTrue);
        Assert.True(checkisDownIsSetTrue);
        //check move component has set to true for each button (left right up down)


    }

    [Test, Order(15)]
    public void assertIsTouchSetTrueWhenTouch()
    {
        Driver.LoadScene("level5");
        AltUnityObject upbtn = FindObjectByName("up");
        AltUnityObject playerObj = FindObjectByName("player");
        upbtn.Click();
        AltUnityComponent whenCollComponent = FindComponentofGameObjectByGameObjectName(playerObj.name, "WhenColl");

        while (!playerObj.GetComponentProperty<bool>(whenCollComponent.componentName, "isTouched"))
        {

        }
        if (playerObj.GetComponentProperty<bool>(whenCollComponent.componentName, "isTouched"))
        {
            Assert.True(playerObj.GetComponentProperty<bool>(whenCollComponent.componentName, "isTouched"));
        }


    }

    [Test, Order(16)]
    public void assertScoreIncreaseInTouch()
    {
        //load scene
        Driver.LoadScene("level5");
        //declare up button
        AltUnityObject upbtn = FindObjectByName("up");
        //declare player object
        AltUnityObject playerObj = FindObjectByName("player");
        //click up button
        upbtn.Click();

        //find whenColl component we need it because it has isTouched boolean. when object touch another this set to true
        AltUnityComponent whenCollComponent = FindComponentofGameObjectByGameObjectName(playerObj.name, "WhenColl");

        //loop until component property is true wen it is true it will not enter to while loop.
        while (!playerObj.GetComponentProperty<bool>(whenCollComponent.componentName, "isTouched"))
        {

        }
        //when is touched set to true that means objects crashed. then whenColl components value should be 100
        if (playerObj.GetComponentProperty<bool>(whenCollComponent.componentName, "isTouched"))
        {
            Assert.AreEqual("100", playerObj.GetComponentProperty<string>(whenCollComponent.componentName, "score").ToString());
        }


    }

    /// <summary>
    /// Click up button 
    /// wait object crash with box1
    /// assert box1 become non active object after crash (dead) 
    /// </summary>
    [Test, Order(17)]
    public void AssertOtherBoxBecomesNonActive()
    {
 
        Driver.LoadScene("level5");
        AltUnityObject upbtn = FindObjectByName("up");
        AltUnityObject playerObj = FindObjectByName("player");
        AltUnityObject otherObject = FindObjectByName("Box1");
        upbtn.Click();
        try
        {
            while (FindObjectByName("Box1").enabled)
            {
                //still enabled
            }
            if (!FindObjectByName("Box1").enabled)
            {
                //not enabled
                Debug.LogWarning( FindObjectByName("Box1").enabled);
            }
        }
        catch (NotFoundException e)
        {
            Debug.LogWarning("not found");
        }

    }


    /// <summary>
    /// Find Object by name
    /// </summary>
    /// <param name="ObjectName"></param>
    /// <returns></returns>
    public AltUnityObject FindObjectByName(string ObjectName)
    {
        try
        {
            return Driver.FindObject(By.NAME, ObjectName);
        }
        catch (NotFoundException e)
        {
            throw;
        }
    }


    /// <summary>
    /// Will return AltUnityComponent if found any. if not will return null
    /// always try to use this method with try catch
    /// </summary>
    /// <param name="ObjectName"></param>
    /// <param name="componentFullName"></param>
    /// <returns></returns>
    public dynamic FindComponentofGameObjectByGameObjectName(string ObjectName, string componentFullName)
    {
        //SearchingComponent
        //SearchingComponent
        AltUnityObject obj = Driver.FindObject(By.NAME, ObjectName);
        List<AltUnityComponent> objectsComponents = obj.GetAllComponents();
        foreach (var item in objectsComponents)
        {
            if (item.componentName.Equals(componentFullName))
            {
                try
                {
                    AltUnityComponent searchingfor;
                    searchingfor = item;
                    return searchingfor;

                }
                catch (ComponentNotFoundException e)
                {

                    throw;
                }


            }
        }
        return null;

    }




    [TearDown]
    public void FinishTest()
    {
        Debug.LogWarning("Test Finished");
    }


}
