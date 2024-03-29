@echo off

echo IP Address received: %1
rem Run scrcpy with the IP address as an argument

adb kill-server
adb start-server

adb tcpip 5555

adb connect %1
adb devices
