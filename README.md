<span> &#128681;</span>NOTE: This article targets Windows users only.
 

Wouldn't it be cool, if we were able to launch an exe that we built/ saved in a particular folder in say F:\ drive be runnable even outside that folder or anywhere you want by typing just the exe name and not including the entire path referencing to it? <span> &#128512;</span>

And by "anywhere" I mean, you can launch your application
<span> &#x26A1;</span>  From start menu (shortcut - **Windows** key)
<span> &#x26A1;</span>  From Run command dialog box (shortcut - **Windows + r**) 
<span> &#x26A1;</span>  By typing application name in Windows Address bar of any drive/ folder on your computer
<span> &#x26A1;</span>  By typing application name from a command prompt opened from any drive/ folder directly without worrying to change the directory.

<span> &#10024;</span>**Sounds interesting?** <span> &#10024;</span>

For demonstration purposes, I have built a very basic C# .NET console application with the name "SayMyName" which outputs the currently logged-in username.

```csharp
using System;

namespace SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.UserName.ToUpper());
            Console.ReadLine();
        }
    }
}
```
The output path of this application is
`T:\MyExe\SayMyName\SayMyName\bin\Debug\SayMyName.exe`

Just make a copy of your exe's path looking like this on a notepad and that's it. It is **all you need** and we are very much good to go!

We will be basically doing two things here to let our computer know about this application.
One, registering the path to exe in the system registry [HKLM](https://en.wikipedia.org/wiki/Windows_Registry#HKEY_LOCAL_MACHINE_(HKLM))
Two, registering the path to exe in [PATH](https://en.wikipedia.org/wiki/PATH_(variable)) environment variable

### Step 1 
[Open windows registry](https://support.microsoft.com/en-us/windows/how-to-open-registry-editor-in-windows-10-deab38e6-91d6-e0aa-4b7c-8878d9e07b11) and go to `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths`

### Step 3
Right-click on `App Paths` and add a `Key` with the name `saymyname.exe`. 

### Step 4
On the right side, you see the `(Default)` value name? Right-click on it click `Modify...`. Now copy-paste the path `T:\MyExe\SayMyName\SayMyName\bin\Debug\SayMyName.exe` and click OK. Now add one more value, by right-clicking -> New -> String value and name it `Path` and set its data value to the exe's containing folder followed by a semicolon i.e. `T:\MyExe\SayMyName\SayMyName\bin\Debug;`

You're almost done! These steps will enable your application to be accessible via the Windows Address bar of any drive and folder, start menu, and Run box.

Just perform this one last step to make your application accessible from any command prompt anywhere.<span> &#128513;</span>

### Step 5
Now go to the Environment Variable window. You can do this by, right-click 'This PC'->Properties-> Advance System Properties->System properties-> Advanced Tab. There you can find the 'Environment Variables...' button. Just smash it!

You will find `Path` variable under the 'User variables' section. Edit it. In the variable value, copy-paste the path `T:\MyExe\SayMyName\SayMyName\bin\Debug;` and click OK.

That's it! There you go. You just made your application a global star on your computer. You can call it from anywhere now <span>  &#128526;</span>
 
There is also a tutorial demostrating the same and it is available [here](https://github.com/pradeepradyumna/saymyname/blob/main/Tutorial.mp4).<span> &#128077;</span>

Thanks for reading!<span> &#128155;</span>
