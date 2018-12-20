## Result

README : https://gist.github.com/guitarrapc/aa612a9995f28292fb6856b2821eb50e

## Build

### Old csproj

Not smart enough build dependency resolver.

```
. "C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin\MSBuild.exe" /t:clean,restore,build src/TestProject_oldcsproj/TestProject.sln
ls src/TestProject_oldcsproj/ConsoleApp1/bin/Debug/
```

result missing C.dll and it's messagepack binary as it never reference in ProjectC

```
Mode                LastWriteTime         Length Name
----                -------------         ------ ----
-a----       2018/12/20     11:35           4096 A.dll
-a----       2018/12/20     11:35          15872 A.pdb
-a----       2018/12/20     11:35           4096 B.dll
-a----       2018/12/20     11:35          15872 B.pdb
-a----       2018/12/20     11:35           4608 ConsoleApp1.exe
-a----       2018/12/20     11:32            189 ConsoleApp1.exe.config
-a----       2018/12/20     11:35          15872 ConsoleApp1.pdb
-a----       2018/11/27     18:07         675240 Newtonsoft.Json.dll
-a----       2018/11/27     17:59         250244 Newtonsoft.Json.pdb
```

### New csproj

Smar build engine.

```
dotnet publish src/TestProject_newcsproj
ls src/TestProject_newcsproj/ConsoleApp1/bin/Debug/net472/publish/
```

```
Mode                LastWriteTime         Length Name
----                -------------         ------ ----
-a----       2018/12/20     12:52           4096 A.dll
-a----       2018/12/20     12:52            504 A.pdb
-a----       2018/12/20     12:52           4096 B.dll
-a----       2018/12/20     12:52            564 B.pdb
-a----       2018/12/20     12:51           4608 C.dll
-a----       2018/12/20     12:51            612 C.pdb
-a----       2018/12/20     12:55           4608 ConsoleApp1.exe
-a----       2018/12/20     12:55            536 ConsoleApp1.pdb
-a----       2018/01/30     15:19         279552 MessagePack.dll
-a----       2018/11/27     18:07         675240 Newtonsoft.Json.dll
-a----       2016/11/05      4:57          25864 System.Threading.Tasks.Extensions.dll
```

