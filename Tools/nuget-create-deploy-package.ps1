.\NuGet.exe pack ..\projects\Crocodev.Common\Crocodev.Common.csproj -IncludeReferencedProjects -Prop Configuration=Release

$apikey   = gc .\nuget.apikey

.\NuGet.exe setApiKey $apikey
.\NuGet.exe push crocodev.common.1.0.0.4.nupkg
