@echo off
REM Change service name and eventually framework version
SET serviceName=WindowsService.exe
SET frameworkVersion=v4.0.30319

%windir%\Microsoft.NET\Framework\%frameworkVersion%\InstallUtil.exe "%~dp0\%serviceName%"
pause