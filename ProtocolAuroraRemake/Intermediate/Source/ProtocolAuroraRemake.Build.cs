using UnrealBuildTool;

public class ProtocolAuroraRemake : ModuleRules
{
	public ProtocolAuroraRemake(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
