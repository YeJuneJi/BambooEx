@echo off
SETLOCAL
call "%VS80COMNTOOLS%\..\..\VC\vcvarsall.bat" x86
"C:\WINDOWS\Microsoft.NET\Framework64\v3.5\msbuild.exe" %*
ENDLOCAL
SET ERR_LEVEL=%errorlevel%
exit /b %ERR_LEVEL%