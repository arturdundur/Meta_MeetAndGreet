# Meta_MeetAndGreet
# Artur Dundur

1. Test script
```C#
using NUnit.Framework;
using UnityEngine;

public class DirectionTest
{
    [Test]
    public void TestNorth()
    {
        Assert.AreEqual(Directions.North, Vector2.up);
    }
    
    [Test]
    public void TestEast()
    {
        Assert.AreEqual(Directions.East, Vector2.right);
    }
    
    [Test]
    public void TestSouth()
    {
        Assert.AreEqual(Directions.South, Vector2.down);
    }
    
    [Test]
    public void TestWest()
    {
        Assert.AreEqual(Directions.West, Vector2.left);
    }
}
```


2. A screenshot of test runner

![image](https://user-images.githubusercontent.com/17411858/193886845-ed53ef4f-c722-4507-ba53-1e5d98c07849.png)

3. The script used to run the tests from the command line
("PATH_TO_YOUR_PROJECT" needs to be replaced with project path, ex. C:\Program Files\UnityProjects\MeetAndGreetProject)

```
"C:\Program Files\Unity\Hub\Editor\2020.3.21f1\Editor\Unity.exe" -runTests -projectPath PATH_TO_PROJECT -testResults C:\temp\results.xml -testPlatform editmode
```

4. XML output of test results

```xml
<?xml version="1.0" encoding="utf-8"?>
<test-run id="2" testcasecount="4" result="Passed" total="4" passed="4" failed="0" inconclusive="0" skipped="0" asserts="0" engine-version="3.5.0.0" clr-version="4.0.30319.42000" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0,0663306">
  <test-suite type="TestSuite" id="1020" name="Meta_Meet&amp;Greet" fullname="Meta_Meet&amp;Greet" runstate="Runnable" testcasecount="4" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.066331" total="4" passed="4" failed="0" inconclusive="0" skipped="0" asserts="0">
    <properties />
    <test-suite type="Assembly" id="1026" name="EditMode.dll" fullname="C:/Users/DundurHome/Desktop/Unity/Meta/Meta_MeetAndGreet/Library/ScriptAssemblies/EditMode.dll" runstate="Runnable" testcasecount="4" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.032814" total="4" passed="4" failed="0" inconclusive="0" skipped="0" asserts="0">
      <properties>
        <property name="_PID" value="25604" />
        <property name="_APPDOMAIN" value="Unity Child Domain" />
        <property name="platform" value="EditMode" />
      </properties>
      <test-suite type="TestFixture" id="1021" name="DirectionTest" fullname="DirectionTest" classname="DirectionTest" runstate="Runnable" testcasecount="4" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.031387" total="4" passed="4" failed="0" inconclusive="0" skipped="0" asserts="0">
        <properties />
        <test-case id="1023" name="TestEast" fullname="DirectionTest.TestEast" methodname="TestEast" classname="DirectionTest" runstate="Runnable" seed="1882510477" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.016525" asserts="0">
          <properties />
        </test-case>
        <test-case id="1022" name="TestNorth" fullname="DirectionTest.TestNorth" methodname="TestNorth" classname="DirectionTest" runstate="Runnable" seed="461746743" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.000352" asserts="0">
          <properties />
        </test-case>
        <test-case id="1024" name="TestSouth" fullname="DirectionTest.TestSouth" methodname="TestSouth" classname="DirectionTest" runstate="Runnable" seed="344297367" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.000217" asserts="0">
          <properties />
        </test-case>
        <test-case id="1025" name="TestWest" fullname="DirectionTest.TestWest" methodname="TestWest" classname="DirectionTest" runstate="Runnable" seed="525569071" result="Passed" start-time="2022-10-04 17:12:19Z" end-time="2022-10-04 17:12:19Z" duration="0.000188" asserts="0">
          <properties />
        </test-case>
      </test-suite>
    </test-suite>
  </test-suite>
</test-run>
```
