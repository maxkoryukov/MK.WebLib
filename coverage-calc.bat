packages\OpenCover.4.6.166\tools\OpenCover.Console.exe -register:user -filter:"+[*]* -[MK.Lib.T]*" -target:"packages\NUnit.Runners.2.6.4\tools\nunit-console.exe" -targetargs:"/noshadow /domain:single src\MK.Lib.T\bin\MK.Lib.T.dll" -output:coverage.xml
