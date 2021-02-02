REM %1 - platform name
REM %2 - TargetDir+TargetName
REM %3 - SolutionDir

echo Platform %1

IF "%1" == "x86" (
	echo C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll"
	C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll"
) ELSE (
	echo C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll" 
	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll"
)

"C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file "%~2.dll" -dr INSTALLFOLDER -srd -sfrag -suid -svb6 -scom -out "%~3Setup\BlinkStickInteropDLL.wxs"
"C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file "%~2.tlb" -dr INSTALLFOLDER -srd -sfrag -suid -svb6 -scom -out "%~3Setup\BlinkStickInteropTLB.wxs"

cd %~dp0

ruby replaceguid.rb
