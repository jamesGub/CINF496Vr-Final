using UnrealBuildTool;

public class ParalangsVRClientTarget : TargetRules
{
	public ParalangsVRClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ParalangsVR");
	}
}
