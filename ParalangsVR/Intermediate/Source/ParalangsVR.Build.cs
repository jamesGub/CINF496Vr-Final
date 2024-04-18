using UnrealBuildTool;

public class ParalangsVR : ModuleRules
{
	public ParalangsVR(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
