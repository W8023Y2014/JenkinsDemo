@echo off

echo Generating APK Files ...

"D:\Program Files\Unity\Editor\Unity.exe" -quit -executeMethod Tools.APKBuild.Build -projectPath "C:\Program Files (x86)\Jenkins\workspace\JenkinsDemo" -logFile build.log
 
echo The APK File Is Generated!!!
-quit