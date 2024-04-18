using UnrealBuildTool;

public class ParalangsVRTarget : TargetRules
{
	public ParalangsVRTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ParalangsVR");
	}
}
