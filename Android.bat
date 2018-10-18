@echo off

echo Generating APK Files ...

"D:\Program Files\Unity\Editor\Unity.exe" -quit -projectPath "C:\Program Files (x86)\Jenkins\workspace\JenkinsDemo"  -executeMethod Tools.APKBuild.Build -logFile build.log
 
echo The APK File Is Generated!!!

quit