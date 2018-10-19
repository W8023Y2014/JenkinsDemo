@echo off

echo Generating APK Files ...

"D:\Program Files\Unity\Editor\Unity.exe" -executeMethod Tools.APKBuild.Build -projectPath G:\Jenkins\workspace\JenkinsDemo -quit -batchmode -logFile build.log
 
echo The APK File Is Generated!!! 