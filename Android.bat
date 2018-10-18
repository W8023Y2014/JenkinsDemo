@echo off

echo Generating APK Files ...

%1 -projectPath %2 -batchmode -executeMethod Tools.APKBuild.Build -logFile build.log
 
echo The APK File Is Generated!!!
pause