REM %1 - platform name
REM %2 - TargetDir+TargetName
REM %3 - SolutionDir


IF %1 == "x86" (
	C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll"
) ELSE (
	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe /codebase /tlb "%~2.dll"
)

"C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file "%~2.dll" -dr INSTALLFOLDER -srd -gg -sfrag -suid -out "%~3Setup\BlinkStickInteropDLL.wxs"
"C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file "%~2.tlb" -dr INSTALLFOLDER -srd -gg -sfrag -suid -out "%~3Setup\BlinkStickInteropTLB.wxs"



REM C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe /codebase /tlb $(TargetPath)

REM "C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file $(TargetPath) -dr INSTALLFOLDER -srd -gg -sfrag -suid -out $(SolutionDir)Setup\BlinkStickInteropDLL.wxs
REM "C:\Program Files (x86)\WiX Toolset v3.9\bin\Heat.exe" file $(TargetDir)$(TargetName).tlb -dr INSTALLFOLDER -srd -gg -sfrag -suid -out $(SolutionDir)Setup\BlinkStickInteropTLB.wxs

