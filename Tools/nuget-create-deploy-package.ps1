$version = "1.0.0.5"
$apikey  = gc .\nuget.apikey

.\NuGet.exe pack ..\projects\Crocodev.Common\Crocodev.Common.csproj -IncludeReferencedProjects -Prop Configuration=Release
.\NuGet.exe setApiKey $apikey
.\NuGet.exe push crocodev.common.$version.nupkg
