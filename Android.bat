@echo off

echo Generating APK Files ...

%1 -quit -executeMethod Tools.APKBuild.Build -projectPath %2 -logFile build.log
 
echo The APK File Is Generated!!!
-quit